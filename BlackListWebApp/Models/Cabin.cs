using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class Cabin
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
