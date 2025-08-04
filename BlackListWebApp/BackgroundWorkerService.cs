using BlackListWebApp.Data;
using BlackListWebApp.Data.Models;
using BlackListWebApp.Interfaces;
using BlackListWebApp.Services;
using Microsoft.EntityFrameworkCore;

public class BackgroundWorkerService : BackgroundService
{
    private readonly ILogger<BackgroundWorkerService> _logger;
    private readonly IServiceProvider _serviceProvider; // Inject the IServiceProvider
    private readonly GraphEmailService _emailService;

    // Modified constructor: Only inject ILogger and IServiceProvider
    public BackgroundWorkerService(ILogger<BackgroundWorkerService> logger, IServiceProvider serviceProvider, GraphEmailService emailService)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
        _emailService = emailService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Background Worker Service starting.");

        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker executing a new unit of work at: {time}", DateTimeOffset.Now);

            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    // Resolve services within the scope
                    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>(); // Assuming your DbContext is named ApplicationDbContext
                    var apiService = scope.ServiceProvider.GetRequiredService<ApiService>();

                    // Get only ACTIVE blacklisted passengers to check
                    var passengersToCheck = await dbContext.BlackListPassengers
                                                          .Where(p => p.StartDate.Date <= DateTime.UtcNow.Date && p.EndDate.Date >= DateTime.UtcNow.Date)
                                                          .ToListAsync(stoppingToken);

                    _logger.LogInformation("Found {Count} active blacklisted passengers to process.", passengersToCheck.Count);

                    foreach (var passenger in passengersToCheck)
                    {
                        // The API response model we created
                        var apiResponse = await apiService.GetBookingByFirstLastNameAsync(passenger.FirstName, passenger.LastName);

                        if (apiResponse?.Results == null || !apiResponse.Results.Any())
                        {
                            continue; // No results for this passenger, move to the next one
                        }

                        foreach (var result in apiResponse.Results)
                        {
                            // CRITICAL: Ensure the passenger from our DB is actually in this specific booking result,
                            // as the API might return bookings for other people with the same last name.
                            var matchedPassenger = result.Passengers.FirstOrDefault(p =>
                                p.FirstName.Equals(passenger.FirstName, StringComparison.OrdinalIgnoreCase) &&
                                p.LastName.Equals(passenger.LastName, StringComparison.OrdinalIgnoreCase));

                            if (matchedPassenger == null)
                            {
                                continue; // The blacklisted person is not in this PNR, skip.
                            }

                            DateTime updateTimestamp = result.BookingDetails.UpdateTimestamp.Value.ToUniversalTime();

                            // Check if we have already logged this exact PNR for this passenger
                            bool alreadyLogged = await dbContext.DetectionLogs.AnyAsync(log =>
                                log.BlackListPassengerId == passenger.Id && log.UpdateTimestamp == updateTimestamp, stoppingToken);

                            if (alreadyLogged)
                            {
                                _logger.LogInformation("passenger {PassengerFullName} has already been logged. Skipping.", passenger.FullName);
                                continue;
                            }

                            _logger.LogInformation("DETECTED: Blacklisted passenger {PassengerFullName} found", passenger.FullName);

                            // Create the main detection log record
                            var newDetection = new DetectionLog
                            {
                                BlackListPassengerId = passenger.Id,
                                Pnr = result.BookingDetails.PnrSequence,
                                DetectionTimestamp = DateTime.UtcNow,
                                UpdateTimestamp = updateTimestamp
                            };

                            // Create the itinerary segments
                            foreach (var segment in result.Itinerary)
                            {
                                newDetection.ItinerarySegments.Add(new FlightSegment
                                {
                                    MarketingAirline = segment.MarketingAirline,
                                    MarketingFlightNumber = segment.MarketingFlightNumber,
                                    DepartureAirportCode = segment.Departure.AirportCode,
                                    DepartureDateTime = segment.Departure.DateTime.Value.ToUniversalTime(),
                                    ArrivalAirportCode = segment.Arrival.AirportCode,
                                    ArrivalDateTime = segment.Arrival.DateTime.Value.ToUniversalTime(),
                                    Status = segment.Status
                                });
                            }

                            // Add the new log and its segments to the context
                            await dbContext.DetectionLogs.AddAsync(newDetection, stoppingToken);

                            // Update the main passenger record to show they have been detected at least once
                            passenger.Detected = true;
                            passenger.UpdatedDate = DateTime.UtcNow;
                            dbContext.BlackListPassengers.Update(passenger);

                            // Save all changes for this detection
                            await dbContext.SaveChangesAsync(stoppingToken);
                            _logger.LogInformation("Successfully saved detection log for PNR {PassengerFullName}.", passenger.FullName);

                            _logger.LogInformation("Condition met. Attempting to send email.");
                            await _emailService.SendEmailAsync(
                                toEmail: "sayedali.maki@gulfairgroup.bh",
                                subject: "Automated Report from Background Service",
                                bodyContent: $"<p>This email was sent automatically at {DateTime.UtcNow:F}.</p>"
                            );
                        }
                    }
                }
            }
            catch (TaskCanceledException)
            {
                _logger.LogInformation("Background worker service has been cancelled.");
                break;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while executing the background worker service.");
            }

            try
            {
                // Wait for the next cycle (5 minutes as requested)
                await Task.Delay(TimeSpan.FromMinutes(5), stoppingToken);
            }
            catch (TaskCanceledException)
            {
                _logger.LogInformation("Background worker service delay was cancelled.");
            }
        }

        _logger.LogInformation("Background worker service has stopped.");
    }
}