using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class BookingDetails
    {
        [JsonPropertyName("locator")]
        public string? Locator { get; set; }

        // Use nullable DateTime? because creationTimestamp can be null
        [JsonPropertyName("creationTimestamp")]
        public DateTime? CreationTimestamp { get; set; }

        [JsonPropertyName("updateTimestamp")]
        public DateTime? UpdateTimestamp { get; set; }

        [JsonPropertyName("creationAgentId")]
        public string? CreationAgentId { get; set; } // Can be null

        [JsonPropertyName("pnrSequence")]
        public string? PnrSequence { get; set; } // Can be null
    }
}
