using BlackListWebApp.Models;

namespace BlackListWebApp.Interfaces
{
    public interface INonVisaService
    {
        // CRUD Operations
        Task<List<NonVisaPassenger>> GetAllPassengersAsync();
        Task<NonVisaPassenger?> GetPassengerByIdAsync(int id);
        Task<NonVisaPassenger> AddPassengerAsync(NonVisaPassenger passenger);
        Task<NonVisaPassenger?> UpdatePassengerAsync(NonVisaPassenger passenger);
        Task<bool> DeletePassengerAsync(int id);

        // Dashboard / Page specific methods
        Task<List<NonVisaPassenger>> SearchAndFilterPassengersAsync(string searchTerm, string violationType);
        Task<int> GetTotalCountAsync();
        Task<int> GetTodayCountAsync();
        Task<int> GetWeekCountAsync();
        Task<(string Type, int Count)> GetMostCommonViolationAsync();
    }
}
