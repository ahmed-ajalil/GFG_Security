using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class FlightPoint
    {
        [JsonPropertyName("airportCode")]
        public string? AirportCode { get; set; }

        [JsonPropertyName("dateTime")]
        public DateTime? DateTime { get; set; }

        [JsonPropertyName("terminal")]
        public string? Terminal { get; set; } // Can be null
    }
}
