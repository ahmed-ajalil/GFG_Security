using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class PaymentDetails
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("cardCode")]
        public string? CardCode { get; set; }

        [JsonPropertyName("maskedCardNumber")]
        public string? MaskedCardNumber { get; set; }

        [JsonPropertyName("expiryDate")]
        public string? ExpiryDate { get; set; }
    }
}
