using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class Remark
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
