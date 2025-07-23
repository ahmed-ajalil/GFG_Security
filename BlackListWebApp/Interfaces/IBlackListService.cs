using BlackListWebApp.Models;

namespace BlackListWebApp.Interfaces
{
    public interface IBlackListService
    {
        Task<List<BlackListPassenger>> GetAllPassengersAsync();
        Task<BlackListPassenger> GetPassengerByIdAsync(int id);
        Task<BlackListPassenger> AddPassengerAsync(BlackListPassenger passenger);
        Task<BlackListPassenger> UpdatePassengerAsync(BlackListPassenger passenger);
        Task<bool> DeletePassengerAsync(int id);
        Task<List<BlackListPassenger>> SearchPassengersAsync(string searchTerm);
        Task<int> GetTodayCountAsync();
        Task<int> GetWeekCountAsync();
        Task<int> GetMonthCountAsync();
        Task<List<BlackListPassenger>?> GetWeekPassengersAsync();
    }
}
