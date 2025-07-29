using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackListWebApp.Data.Models
{
    public class DetectionLog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BlackListPassengerId { get; set; }

        [ForeignKey("BlackListPassengerId")]
        public BlackListPassenger BlackListPassenger { get; set; } = null!;

        [StringLength(50)]
        public string? Pnr { get; set; } = string.Empty;

        [Required]
        public DateTime DetectionTimestamp { get; set; } = DateTime.UtcNow;
        public DateTime UpdateTimestamp { get; set; } = DateTime.UtcNow;

        // This will hold all the flight segments associated with this one detection/PNR
        public ICollection<FlightSegment> ItinerarySegments { get; set; } = new List<FlightSegment>();
    }
}
