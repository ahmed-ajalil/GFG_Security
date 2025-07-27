using BlackListWebApp.Data;
using BlackListWebApp.Data.Models;
using BlackListWebApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlackListWebApp.Services
{
    public class NonVisaService : INonVisaService
    {
        private readonly ApplicationDbContext _dbContext;

        public NonVisaService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<NonVisaPassenger>> GetAllPassengersAsync()
        {
            return await _dbContext.NonVisaPassengers
                .OrderByDescending(p => p.CreatedDate)
                .ToListAsync();
        }

        public async Task<NonVisaPassenger?> GetPassengerByIdAsync(int id)
        {
            return await _dbContext.NonVisaPassengers.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<NonVisaPassenger> AddPassengerAsync(NonVisaPassenger passenger)
        {
            var newPassenger = new NonVisaPassenger
            {
                // Map properties from the incoming object
                FirstName = passenger.FirstName,
                LastName = passenger.LastName,
                Nationality = passenger.Nationality,
                PNR = passenger.PNR,
                PassportNumber = passenger.PassportNumber,
                Mobile = passenger.Mobile,
                FlightNumber = passenger.FlightNumber,
                AirportStation = passenger.AirportStation,
                ViolationType = passenger.ViolationType,
                Purpose = passenger.Purpose,
                Remarks = passenger.Remarks,

                // --- LOGIC AND STATE SET ON THE SERVER ---

                // The service is responsible for setting the initial status.
                // Do not trust the client to provide this.
                Status = "Pending Review",

                // Standardize the incoming date to UTC at midnight.
                ArrivalDate = DateTime.SpecifyKind(passenger.ArrivalDate.Date, DateTimeKind.Utc),

                // Set the creation timestamp on the server.
                CreatedDate = DateTime.UtcNow,
            };

            await _dbContext.NonVisaPassengers.AddAsync(newPassenger);
            await _dbContext.SaveChangesAsync();
            return newPassenger;
        }

        public async Task<NonVisaPassenger?> UpdatePassengerAsync(NonVisaPassenger passenger)
        {
            var existingPassenger = await _dbContext.NonVisaPassengers.FindAsync(passenger.Id);
            if (existingPassenger == null)
            {
                return null;
            }

            existingPassenger.FirstName = passenger.FirstName;
            existingPassenger.LastName = passenger.LastName;
            existingPassenger.Nationality = passenger.Nationality;
            existingPassenger.PNR = passenger.PNR;
            existingPassenger.PassportNumber = passenger.PassportNumber;
            existingPassenger.Mobile = passenger.Mobile;
            existingPassenger.FlightNumber = passenger.FlightNumber;
            existingPassenger.AirportStation = passenger.AirportStation;
            existingPassenger.ViolationType = passenger.ViolationType;
            existingPassenger.Purpose = passenger.Purpose;
            existingPassenger.Remarks = passenger.Remarks;
            existingPassenger.Status = passenger.Status;

            // Standardize the incoming date to UTC at midnight.
            existingPassenger.ArrivalDate = DateTime.SpecifyKind(passenger.ArrivalDate.Date, DateTimeKind.Utc);

            await _dbContext.SaveChangesAsync();
            return existingPassenger;
        }

        public async Task<bool> DeletePassengerAsync(int id)
        {
            var passenger = await _dbContext.NonVisaPassengers.FindAsync(id);
            if (passenger != null)
            {
                _dbContext.NonVisaPassengers.Remove(passenger);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<NonVisaPassenger>> GetFilteredPassengersAsync(string searchTerm, string violationType, string sortBy)
        {
            var query = _dbContext.NonVisaPassengers.AsQueryable();

            // Apply violation type filter (this is fine)
            if (!string.IsNullOrWhiteSpace(violationType))
            {
                query = query.Where(p => p.ViolationType == violationType);
            }

            // Apply search term filter (this is the critical fix)
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string lowerCaseSearchTerm = searchTerm.ToLower();

                // This new WHERE clause is now completely safe from null reference errors
                query = query.Where(p =>
                    (p.FirstName.ToLower() + " " + p.LastName.ToLower()).Contains(lowerCaseSearchTerm) ||
                    (p.Nationality ?? "").ToLower().Contains(lowerCaseSearchTerm) ||
                    (p.PassportNumber ?? "").ToLower().Contains(lowerCaseSearchTerm) ||
                    (p.FlightNumber ?? "").ToLower().Contains(lowerCaseSearchTerm) ||
                    (p.AirportStation.ToLower().Contains(lowerCaseSearchTerm)) || // AirportStation is required, so no null check needed
                    (p.PNR ?? "").ToLower().Contains(lowerCaseSearchTerm) ||
                    (p.Mobile ?? "").ToLower().Contains(lowerCaseSearchTerm)
                );
            }

            // Apply sorting (this is fine)
            query = sortBy switch
            {
                "name" => query.OrderBy(p => p.FirstName).ThenBy(p => p.LastName),
                "nationality" => query.OrderBy(p => p.Nationality),
                "violationType" => query.OrderBy(p => p.ViolationType),
                _ => query.OrderByDescending(p => p.ArrivalDate)
            };

            return await query.ToListAsync();
        }

        public async Task<int> GetTotalCountAsync()
        {
            return await _dbContext.NonVisaPassengers.CountAsync();
        }

        public async Task<int> GetTodayCountAsync()
        {
            var todayUtc = DateTime.UtcNow.Date;
            return await _dbContext.NonVisaPassengers.CountAsync(p => p.ArrivalDate.Date == todayUtc);
        }

        public async Task<int> GetWeekCountAsync()
        {
            //var startOfWeek = DateTime.UtcNow.Date.AddDays(-(int)DateTime.UtcNow.DayOfWeek);
            //var endOfWeek = startOfWeek.AddDays(7);
            //return await _dbContext.NonVisaPassengers.CountAsync(p => p.ArrivalDate >= startOfWeek && p.ArrivalDate < endOfWeek);

            var weekAgoUtc = DateTime.UtcNow.Date.AddDays(-7);
            return await _dbContext.NonVisaPassengers.CountAsync(p => p.ArrivalDate.Date >= weekAgoUtc);
        }


        public async Task<(string Type, int Count)> GetMostCommonViolationAsync()
        {
            var result = await _dbContext.NonVisaPassengers
                .GroupBy(p => p.ViolationType)
                .Select(g => new { ViolationType = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .FirstOrDefaultAsync();

            return result != null ? (result.ViolationType, result.Count) : ("None", 0);
        }
    }
}
