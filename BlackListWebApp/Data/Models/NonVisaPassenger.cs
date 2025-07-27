using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackListWebApp.Data.Models
{
    public class NonVisaPassenger
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string? Nationality { get; set; }

        [StringLength(50)]
        public string? PNR { get; set; }

        [StringLength(50)]
        public string? PassportNumber { get; set; }

        [StringLength(50)]
        public string? Mobile { get; set; }

        [StringLength(50)]
        public string? FlightNumber { get; set; }

        [Required]
        public DateTime ArrivalDate { get; set; }

        [Required]
        [StringLength(50)]
        public string AirportStation { get; set; }

        [Required]
        [StringLength(50)]
        public string ViolationType { get; set; }

        [StringLength(500)]
        public string? Purpose { get; set; }

        [StringLength(500)]
        public string? Remarks { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
