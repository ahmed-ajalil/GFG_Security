using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class SearchByFirstLastNameResponse
    {
        [JsonPropertyName("searchQuery")]
        public SearchQuery SearchQuery { get; set; }
        [JsonPropertyName("results")]
        public List<BookingResponse> Results { get; set; }
    }
}
