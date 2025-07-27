using System.Text.Json.Serialization;

namespace BlackListWebApp.Models
{
    public class BookingResponse
    {
        [JsonPropertyName("bookingDetails")]
        public BookingDetails? BookingDetails { get; set; }

        [JsonPropertyName("pointOfSale")]
        public PointOfSale? PointOfSale { get; set; } // Can be null

        [JsonPropertyName("passengers")]
        public List<Passenger>? Passengers { get; set; }

        [JsonPropertyName("itinerary")]
        public List<ItinerarySegment>? Itinerary { get; set; }

        [JsonPropertyName("contacts")]
        public List<Contact>? Contacts { get; set; }

        [JsonPropertyName("paymentDetails")]
        public PaymentDetails? PaymentDetails { get; set; } // Can be null

        [JsonPropertyName("remarks")]
        public List<Remark>? Remarks { get; set; }

        [JsonPropertyName("ticketNumbers")]
        public List<string>? TicketNumbers { get; set; }
    }
}
