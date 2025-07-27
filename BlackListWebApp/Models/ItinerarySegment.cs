using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class ItinerarySegment
    {
        [JsonPropertyName("sequence")]
        public int Sequence { get; set; }

        [JsonPropertyName("marketingAirline")]
        public string? MarketingAirline { get; set; }

        [JsonPropertyName("marketingFlightNumber")]
        public string? MarketingFlightNumber { get; set; }

        [JsonPropertyName("operatingAirline")]
        public string? OperatingAirline { get; set; } // Can be null

        [JsonPropertyName("operatingFlightNumber")]
        public string? OperatingFlightNumber { get; set; } // Can be null

        [JsonPropertyName("classOfService")]
        public string? ClassOfService { get; set; }

        [JsonPropertyName("equipmentType")]
        public string? EquipmentType { get; set; } // Can be null

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("departure")]
        public FlightPoint? Departure { get; set; }

        [JsonPropertyName("arrival")]
        public FlightPoint? Arrival { get; set; }

        [JsonPropertyName("cabin")]
        public Cabin? Cabin { get; set; } // Can be null
    }
}
