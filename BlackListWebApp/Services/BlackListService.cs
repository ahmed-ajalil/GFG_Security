using BlackListWebApp.Data;
using BlackListWebApp.Interfaces;
using BlackListWebApp.Models;
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
            try
            {
                var allPassengers = await _dbContext.BlackListPassengers.OrderByDescending(p => p.CreatedDate).ToListAsync();
                return allPassengers;
            }
            catch (Exception ex)
            {
                return new List<BlackListPassenger>();
            }
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
            try
            {
                passenger.CreatedDate = DateTime.UtcNow;
                await _dbContext.BlackListPassengers.AddAsync(passenger);
                _dbContext.SaveChanges();
                return passenger;
            }
            catch (Exception ex)
            {
                return new BlackListPassenger();
            }
        }

        public async Task<BlackListPassenger> UpdatePassengerAsync(BlackListPassenger passenger)
        {
            try
            {
                var existingPassenger = await _dbContext.BlackListPassengers.FirstOrDefaultAsync(p => p.Id == passenger.Id);
                if (existingPassenger != null)
                {
                    // Using EF Core's entry state is often cleaner than manual assignment
                    _dbContext.Entry(existingPassenger).CurrentValues.SetValues(passenger);
                    existingPassenger.UpdatedDate = DateTime.UtcNow;
                    // Note: SetValues will overwrite CreatedDate. Let's preserve it.
                    existingPassenger.CreatedDate = _dbContext.Entry(existingPassenger).OriginalValues.GetValue<DateTime>(nameof(BlackListPassenger.CreatedDate));

                    _dbContext.BlackListPassengers.Update(existingPassenger);
                    await _dbContext.SaveChangesAsync(); // CHANGED: Use async version

                    return existingPassenger;
                }
                return passenger;
            }
            catch (Exception ex)
            {
                return new BlackListPassenger();
            }
        }

        public async Task<bool> DeletePassengerAsync(int id)
        {
            try
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
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<BlackListPassenger>> SearchPassengersAsync(string searchTerm)
        {
            try
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
            catch (Exception ex)
            {
                // Consider logging the exception ex
                return new List<BlackListPassenger>();
            }
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
