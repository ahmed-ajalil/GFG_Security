using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackListWebApp.Data.Models
{
    public class FlightSegment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DetectionLogId { get; set; }

        [ForeignKey("DetectionLogId")]
        public DetectionLog DetectionLog { get; set; } = null!;

        [StringLength(10)]
        public string MarketingAirline { get; set; } = string.Empty;

        [StringLength(10)]
        public string MarketingFlightNumber { get; set; } = string.Empty;

        [StringLength(10)]
        public string DepartureAirportCode { get; set; } = string.Empty;
        public DateTime DepartureDateTime { get; set; }

        [StringLength(10)]
        public string ArrivalAirportCode { get; set; } = string.Empty;
        public DateTime ArrivalDateTime { get; set; }

        [StringLength(10)]
        public string Status { get; set; } = string.Empty; // e.g., "HK" for confirmed

        public string FullFlightNumber => $"{MarketingAirline}{MarketingFlightNumber}";
    }
}
