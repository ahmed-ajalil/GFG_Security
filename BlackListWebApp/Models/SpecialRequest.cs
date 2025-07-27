using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class SpecialRequest
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("freeText")]
        public string? FreeText { get; set; }

        [JsonPropertyName("ticketNumber")]
        public string? TicketNumber { get; set; }
    }
}
