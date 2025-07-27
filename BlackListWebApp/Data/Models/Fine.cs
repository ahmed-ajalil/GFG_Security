using System.ComponentModel.DataAnnotations;

namespace BlackListWebApp.Data.Models
{
    public class Fine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [StringLength(50)]
        public string? PaxName { get; set; }

        [StringLength(50)]
        public string? OrginalStation { get; set; }

        [StringLength(50)]
        public string? DestinationStation { get; set; }

        [StringLength(50)]
        public string? Nationality { get; set; }

        [StringLength(50)]
        public string? OriginalTKTNumber { get; set; }

        [StringLength(50)]
        public string? FltDetails { get; set; }

        [StringLength(50)]
        public string? IssuedCodEmdNumber { get; set; }

        [StringLength(100)]
        public string? INADReason { get; set; }

        [StringLength(50)]
        public string? DeportedTo { get; set; }

        [StringLength(50)]
        public string? FineAmount { get; set; }

        [StringLength(50)]
        public string? OtherFines { get; set; }

        [StringLength(50)]
        public string? StatusOfRecovery { get; set; }

        [StringLength(500)]
        public string? Remarks { get; set; }
    }
}
