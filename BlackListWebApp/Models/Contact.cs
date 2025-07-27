using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class Contact
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; } // Can be null
    }
}
