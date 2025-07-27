using System.ComponentModel.DataAnnotations;

namespace BlackListWebApp.Data.Models
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
