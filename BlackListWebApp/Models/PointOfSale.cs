using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class PointOfSale
    {
        [JsonPropertyName("pseudoCityCode")]
        public string? PseudoCityCode { get; set; }

        [JsonPropertyName("agentSine")]
        public string? AgentSine { get; set; }

        [JsonPropertyName("isoCountry")]
        public string? IsoCountry { get; set; }

        [JsonPropertyName("airlineVendorId")]
        public string? AirlineVendorId { get; set; }
    }
}
