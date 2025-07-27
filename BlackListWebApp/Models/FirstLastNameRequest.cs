using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class FirstLastNameRequest
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
    }
}
