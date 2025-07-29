using BlackListWebApp.Models;

namespace BlackListWebApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BookingResponse?> GetBookingDetailsByPnrAsync(string pnrLocator)
        {
            var requestPayload = new PnrRequest { Locator = pnrLocator };

            // The endpoint is relative to the BaseAddress we will configure
            var response = await _httpClient.PostAsJsonAsync("api/Sabre/detailsByPNRCert", requestPayload);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<BookingResponse>();
        }

        public async Task<SearchByFirstLastNameResponse?> GetBookingByFirstLastNameAsync(string firstName, string lastName)
        {
            try
            {
                var requestPayload = new FirstLastNameRequest { FirstName = firstName, LastName = lastName };

                // The endpoint is relative to the BaseAddress we will configure
                var response = await _httpClient.PostAsJsonAsync("api/Sabre/searchByFirstLastName", requestPayload);

                response.EnsureSuccessStatusCode();

                var data = await response.Content.ReadFromJsonAsync<SearchByFirstLastNameResponse>();
                return data;
            }
            catch(Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }  
        }
    }
}
