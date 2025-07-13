using BlackListWebApp.Models;

namespace BlackListWebApp.Services
{
    public interface IBlackListService
    {
        Task<List<BlackListPassenger>> GetAllPassengersAsync();
        Task<BlackListPassenger?> GetPassengerByIdAsync(int id);
        Task<BlackListPassenger> AddPassengerAsync(BlackListPassenger passenger);
        Task<BlackListPassenger> UpdatePassengerAsync(BlackListPassenger passenger);
        Task<bool> DeletePassengerAsync(int id);
        Task<List<BlackListPassenger>> SearchPassengersAsync(string searchTerm);
        Task<int> GetTodayCountAsync();
        Task<int> GetWeekCountAsync();
        Task<int> GetMonthCountAsync();
        Task<List<BlackListPassenger>> GetWeekPassengersAsync();
    }

    public class BlackListService : IBlackListService
    {
        private readonly List<BlackListPassenger> _passengers;

        public BlackListService()
        {
            // Sample data
            _passengers = new List<BlackListPassenger>
            {
                new BlackListPassenger
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    Reason = "Security threat - suspicious behavior at security checkpoint",
                    StartDate = DateTime.Today.AddDays(-5),
                    EndDate = DateTime.Today.AddDays(25),
                    CreatedDate = DateTime.Today.AddDays(-5)
                },
                new BlackListPassenger
                {
                    Id = 2,
                    FirstName = "Sarah",
                    LastName = "Johnson",
                    Reason = "Flight disruption - aggressive behavior towards crew",
                    StartDate = DateTime.Today.AddDays(-10),
                    EndDate = DateTime.Today.AddDays(20),
                    CreatedDate = DateTime.Today.AddDays(-10)
                },
                new BlackListPassenger
                {
                    Id = 3,
                    FirstName = "Michael",
                    LastName = "Brown",
                    Reason = "Document fraud - attempted to board with fake identification",
                    StartDate = DateTime.Today.AddDays(-2),
                    EndDate = DateTime.Today.AddDays(58),
                    CreatedDate = DateTime.Today.AddDays(-2)
                },
                new BlackListPassenger
                {
                    Id = 4,
                    FirstName = "Emma",
                    LastName = "Davis",
                    Reason = "Prohibited items - attempted to bring dangerous materials",
                    StartDate = DateTime.Today.AddDays(-7),
                    EndDate = DateTime.Today.AddDays(23),
                    CreatedDate = DateTime.Today.AddDays(-7)
                },
                new BlackListPassenger
                {
                    Id = 5,
                    FirstName = "Robert",
                    LastName = "Wilson",
                    Reason = "Intoxication - boarded aircraft under influence of alcohol",
                    StartDate = DateTime.Today.AddDays(-1),
                    EndDate = DateTime.Today.AddDays(29),
                    CreatedDate = DateTime.Today.AddDays(-1)
                },
                new BlackListPassenger
                {
                    Id = 6,
                    FirstName = "Lisa",
                    LastName = "Anderson",
                    Reason = "Harassment - inappropriate behavior towards other passengers",
                    StartDate = DateTime.Today.AddDays(-15),
                    EndDate = DateTime.Today.AddDays(15),
                    CreatedDate = DateTime.Today.AddDays(-15)
                },
                new BlackListPassenger
                {
                    Id = 7,
                    FirstName = "David",
                    LastName = "Martinez",
                    Reason = "Non-compliance - refused to follow safety instructions",
                    StartDate = DateTime.Today.AddDays(-3),
                    EndDate = DateTime.Today.AddDays(27),
                    CreatedDate = DateTime.Today.AddDays(-3)
                },
                new BlackListPassenger
                {
                    Id = 8,
                    FirstName = "Jennifer",
                    LastName = "Taylor",
                    Reason = "Verbal abuse - threatening language towards airline staff",
                    StartDate = DateTime.Today.AddDays(-6),
                    EndDate = DateTime.Today.AddDays(24),
                    CreatedDate = DateTime.Today.AddDays(-6)
                }
            };
        }

        public async Task<List<BlackListPassenger>> GetAllPassengersAsync()
        {
            await Task.Delay(10); // Simulate async operation
            return _passengers.OrderByDescending(p => p.CreatedDate).ToList();
        }

        public async Task<BlackListPassenger?> GetPassengerByIdAsync(int id)
        {
            await Task.Delay(10);
            return _passengers.FirstOrDefault(p => p.Id == id);
        }

        public async Task<BlackListPassenger> AddPassengerAsync(BlackListPassenger passenger)
        {
            await Task.Delay(10);
            passenger.Id = _passengers.Max(p => p.Id) + 1;
            passenger.CreatedDate = DateTime.Now;
            _passengers.Add(passenger);
            return passenger;
        }

        public async Task<BlackListPassenger> UpdatePassengerAsync(BlackListPassenger passenger)
        {
            await Task.Delay(10);
            var existingPassenger = _passengers.FirstOrDefault(p => p.Id == passenger.Id);
            if (existingPassenger != null)
            {
                existingPassenger.FirstName = passenger.FirstName;
                existingPassenger.LastName = passenger.LastName;
                existingPassenger.Reason = passenger.Reason;
                existingPassenger.StartDate = passenger.StartDate;
                existingPassenger.EndDate = passenger.EndDate;
                existingPassenger.UpdatedDate = DateTime.Now;
                return existingPassenger;
            }
            return passenger;
        }

        public async Task<bool> DeletePassengerAsync(int id)
        {
            await Task.Delay(10);
            var passenger = _passengers.FirstOrDefault(p => p.Id == id);
            if (passenger != null)
            {
                _passengers.Remove(passenger);
                return true;
            }
            return false;
        }

        public async Task<List<BlackListPassenger>> SearchPassengersAsync(string searchTerm)
        {
            await Task.Delay(10);
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await GetAllPassengersAsync();

            searchTerm = searchTerm.ToLower();
            return _passengers.Where(p => 
                p.FirstName.ToLower().Contains(searchTerm) || 
                p.LastName.ToLower().Contains(searchTerm) ||
                p.Reason.ToLower().Contains(searchTerm))
                .OrderByDescending(p => p.CreatedDate)
                .ToList();
        }

        public async Task<int> GetTodayCountAsync()
        {
            await Task.Delay(10);
            return _passengers.Count(p => p.CreatedDate.Date == DateTime.Today);
        }

        public async Task<int> GetWeekCountAsync()
        {
            await Task.Delay(10);
            var weekAgo = DateTime.Today.AddDays(-7);
            return _passengers.Count(p => p.CreatedDate >= weekAgo);
        }

        public async Task<int> GetMonthCountAsync()
        {
            await Task.Delay(10);
            var monthAgo = DateTime.Today.AddDays(-30);
            return _passengers.Count(p => p.CreatedDate >= monthAgo);
        }

        public async Task<List<BlackListPassenger>> GetWeekPassengersAsync()
        {
            await Task.Delay(10);
            var weekAgo = DateTime.Today.AddDays(-7);
            return _passengers
                .Where(p => p.CreatedDate >= weekAgo)
                .OrderByDescending(p => p.CreatedDate)
                .ToList();
        }
    }
}
