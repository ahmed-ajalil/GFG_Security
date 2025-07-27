using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class Passenger
    {
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        [JsonPropertyName("specialRequests")]
        public List<SpecialRequest>? SpecialRequests { get; set; }
    }
}
