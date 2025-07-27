using BlackListWebApp.Data;
using BlackListWebApp.Data.Models;
using BlackListWebApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlackListWebApp.Services
{
    public class BlackListService : IBlackListService
    {
        private readonly ApplicationDbContext _dbContext;

        public BlackListService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BlackListPassenger>?> GetAllPassengersAsync()
        {
            var allPassengers = await _dbContext.BlackListPassengers.OrderByDescending(p => p.CreatedDate).ToListAsync();
            return allPassengers;
        }

        public async Task<BlackListPassenger> GetPassengerByIdAsync(int id)
        {
            try
            {
                var passenger = await _dbContext.BlackListPassengers.Where(x => x.Id == id).FirstOrDefaultAsync();
                return passenger;
            }
            catch (Exception ex)
            {
                return new BlackListPassenger();
            }
        }

        public async Task<BlackListPassenger> AddPassengerAsync(BlackListPassenger passenger)
        {
            // Create a new entity instance to prevent over-posting vulnerabilities.
            var newPassenger = new BlackListPassenger
            {
                FirstName = passenger.FirstName,
                LastName = passenger.LastName,
                Nationality = passenger.Nationality,
                PNR = passenger.PNR,
                PassportNumber = passenger.PassportNumber,
                Mobile = passenger.Mobile,
                Reason = passenger.Reason,

                // Standardize incoming dates to UTC at midnight.
                StartDate = DateTime.SpecifyKind(passenger.StartDate.Date, DateTimeKind.Utc),
                EndDate = DateTime.SpecifyKind(passenger.EndDate.Date, DateTimeKind.Utc),

                // Set timestamps on the server to ensure data integrity.
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = null
            };

            await _dbContext.BlackListPassengers.AddAsync(newPassenger);
            await _dbContext.SaveChangesAsync(); // CORRECTED: Use async version.

            return newPassenger;
        }

        public async Task<BlackListPassenger> UpdatePassengerAsync(BlackListPassenger passenger)
        {
            var existingPassenger = await _dbContext.BlackListPassengers.FindAsync(passenger.Id);

            if (existingPassenger == null)
            {
                return null; // Passenger not found
            }

            // Assign properties from the incoming object
            existingPassenger.FirstName = passenger.FirstName;
            existingPassenger.LastName = passenger.LastName;
            existingPassenger.Nationality = passenger.Nationality;
            existingPassenger.PNR = passenger.PNR;
            existingPassenger.PassportNumber = passenger.PassportNumber;
            existingPassenger.Mobile = passenger.Mobile;
            existingPassenger.Reason = passenger.Reason;

            // --- CORRECTED DATE HANDLING ---
            // The InputDate component sends a DateTime object. We take only the Date part
            // and explicitly specify its Kind as Utc before saving. This stores it as
            // a pure date (at midnight) in UTC.
            existingPassenger.StartDate = DateTime.SpecifyKind(passenger.StartDate.Date, DateTimeKind.Utc);
            existingPassenger.EndDate = DateTime.SpecifyKind(passenger.EndDate.Date, DateTimeKind.Utc);

            // Set the server-side update timestamp to UtcNow
            existingPassenger.UpdatedDate = DateTime.UtcNow;

            // The CreatedDate is not touched, preserving its original value.

            await _dbContext.SaveChangesAsync();

            return existingPassenger;
        }

        public async Task<bool> DeletePassengerAsync(int id)
        {
            var passenger = await _dbContext.BlackListPassengers.FirstOrDefaultAsync(p => p.Id == id);
            if (passenger != null)
            {
                _dbContext.BlackListPassengers.Remove(passenger);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<List<BlackListPassenger>> SearchPassengersAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return await GetAllPassengersAsync();
            }

            var lowerCaseSearchTerm = searchTerm.ToLower();

            // IMPROVED: Enhanced search query
            var query = _dbContext.BlackListPassengers.Where(p =>
                p.FirstName.ToLower().Contains(lowerCaseSearchTerm) ||
                p.LastName.ToLower().Contains(lowerCaseSearchTerm) ||
                p.Reason.ToLower().Contains(lowerCaseSearchTerm) ||
                (p.Nationality != null && p.Nationality.ToLower().Contains(lowerCaseSearchTerm)) ||
                (p.PNR != null && p.PNR.ToLower().Contains(lowerCaseSearchTerm)) ||
                (p.PassportNumber != null && p.PassportNumber.ToLower().Contains(lowerCaseSearchTerm)) ||
                (p.Mobile != null && p.Mobile.ToLower().Contains(lowerCaseSearchTerm))
            );

            return await query.OrderByDescending(p => p.CreatedDate).ToListAsync(); // CHANGED: Use async version

        }

        public async Task<int> GetTodayCountAsync()
        {
            var todayUtc = DateTime.UtcNow.Date;
            return await _dbContext.BlackListPassengers.CountAsync(p => p.CreatedDate.Date == todayUtc);

        }

        public async Task<int> GetWeekCountAsync()
        {
            var weekAgoUtc = DateTime.UtcNow.AddDays(-7);
            return await _dbContext.BlackListPassengers.CountAsync(p => p.CreatedDate >= weekAgoUtc);
        }

        public async Task<int> GetMonthCountAsync()
        {
            var monthAgoUtc = DateTime.UtcNow.AddMonths(-1); // More accurate for a month
            return await _dbContext.BlackListPassengers.CountAsync(p => p.CreatedDate >= monthAgoUtc);

        }

        public async Task<List<BlackListPassenger>> GetWeekPassengersAsync()
        {
            var weekAgoUtc = DateTime.UtcNow.AddDays(-7);
            return await _dbContext.BlackListPassengers
                .Where(p => p.CreatedDate >= weekAgoUtc)
                .OrderByDescending(p => p.CreatedDate)
                .ToListAsync();
        }
    }
}
