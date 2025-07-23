using BlackListWebApp.Data;
using BlackListWebApp.Interfaces;
using BlackListWebApp.Models;
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
            passenger.CreatedDate = DateTime.UtcNow;
            await _dbContext.NonVisaPassengers.AddAsync(passenger);
            await _dbContext.SaveChangesAsync();
            return passenger;
        }

        public async Task<NonVisaPassenger?> UpdatePassengerAsync(NonVisaPassenger passenger)
        {
            var existingPassenger = await _dbContext.NonVisaPassengers.FindAsync(passenger.Id);
            if (existingPassenger != null)
            {
                // Note: The NonVisaPassenger model doesn't have an UpdatedDate.
                // If it did, we would set it here: existingPassenger.UpdatedDate = DateTime.UtcNow;
                _dbContext.Entry(existingPassenger).CurrentValues.SetValues(passenger);
                await _dbContext.SaveChangesAsync();
                return existingPassenger;
            }
            return null;
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

        public async Task<List<NonVisaPassenger>> SearchAndFilterPassengersAsync(string searchTerm, string violationType)
        {
            var query = _dbContext.NonVisaPassengers.AsQueryable();

            // Apply violation type filter
            if (!string.IsNullOrWhiteSpace(violationType))
            {
                query = query.Where(p => p.ViolationType == violationType);
            }

            // Apply search term filter (case-insensitive)
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var searchPattern = $"%{searchTerm}%";
                query = query.Where(p =>
                    EF.Functions.ILike(p.FirstName, searchPattern) ||
                    EF.Functions.ILike(p.LastName, searchPattern) ||
                    EF.Functions.ILike(p.Nationality, searchPattern) ||
                    EF.Functions.ILike(p.PassportNumber, searchPattern) ||
                    EF.Functions.ILike(p.FlightNumber, searchPattern) ||
                    EF.Functions.ILike(p.AirportStation, searchPattern));
            }

            return await query.OrderByDescending(p => p.CreatedDate).ToListAsync();
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
            var startOfWeek = DateTime.UtcNow.Date.AddDays(-(int)DateTime.UtcNow.DayOfWeek);
            var endOfWeek = startOfWeek.AddDays(7);
            return await _dbContext.NonVisaPassengers.CountAsync(p => p.ArrivalDate >= startOfWeek && p.ArrivalDate < endOfWeek);
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
