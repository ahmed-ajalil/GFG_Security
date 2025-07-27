using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class SearchQuery
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
    }
}
