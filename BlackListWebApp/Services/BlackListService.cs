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
                passenger.CreatedDate = DateTime.Now;
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
                    existingPassenger.FirstName = passenger.FirstName;
                    existingPassenger.LastName = passenger.LastName;
                    existingPassenger.Nationality = passenger.Nationality;
                    existingPassenger.PNR = passenger.PNR;
                    existingPassenger.PassportNumber = passenger.PassportNumber;
                    existingPassenger.Mobile = passenger.Mobile;
                    existingPassenger.Reason = passenger.Reason;
                    existingPassenger.StartDate = passenger.StartDate;
                    existingPassenger.EndDate = passenger.EndDate;
                    existingPassenger.UpdatedDate = DateTime.Now;
                    _dbContext.BlackListPassengers.Update(existingPassenger);
                    _dbContext.SaveChanges();

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
                    _dbContext.SaveChanges();
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
                    return await GetAllPassengersAsync();

                searchTerm = searchTerm.ToLower();
                return _dbContext.BlackListPassengers.Where(p =>
                    p.FirstName.ToLower().Contains(searchTerm) ||
                    p.LastName.ToLower().Contains(searchTerm) ||
                    p.Reason.ToLower().Contains(searchTerm))
                    .OrderByDescending(p => p.CreatedDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                return new List<BlackListPassenger>();
            }
        }

        public async Task<int> GetTodayCountAsync()
        {
            try
            {
                return await _dbContext.BlackListPassengers.CountAsync(p => p.CreatedDate.Date == DateTime.Today);
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<int> GetWeekCountAsync()
        {
            try
            {
                var weekAgo = DateTime.Today.AddDays(-7);
                return await _dbContext.BlackListPassengers.CountAsync(p => p.CreatedDate >= weekAgo);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> GetMonthCountAsync()
        {
            try
            {
                var monthAgo = DateTime.Today.AddDays(-30);
                return await _dbContext.BlackListPassengers.CountAsync(p => p.CreatedDate >= monthAgo);
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<List<BlackListPassenger>> GetWeekPassengersAsync()
        {
            try
            {
                var weekAgo = DateTime.Today.AddDays(-7);
                return await _dbContext.BlackListPassengers
                    .Where(p => p.CreatedDate >= weekAgo)
                    .OrderByDescending(p => p.CreatedDate)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<BlackListPassenger>();
            }
        }
    }
}
