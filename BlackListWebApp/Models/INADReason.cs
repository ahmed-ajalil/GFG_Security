using System.ComponentModel.DataAnnotations;

namespace BlackListWebApp.Models
{
    public class INADReason
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Reason { get; set; }
    }
}
