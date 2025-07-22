using System.ComponentModel.DataAnnotations;

namespace BlackListWebApp.Models
{
    public class BlackListPassenger
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        public string LastName { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Nationality { get; set; }

        [StringLength(50)]
        public string? PNR { get; set; }

        [StringLength(50)]
        public string? PassportNumber { get; set; }

        [StringLength(50)]
        public string? Mobile { get; set; }

        [Required(ErrorMessage = "Reason is required")]
        [StringLength(500, ErrorMessage = "Reason cannot exceed 500 characters")]
        public string Reason { get; set; } = string.Empty;

        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; } = DateTime.Today.AddDays(30);

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public bool IsActive => DateTime.Today >= StartDate && DateTime.Today <= EndDate;
        public string Status => IsActive ? "Active" : "Inactive";
        public int DaysRemaining => EndDate > DateTime.Today ? (EndDate - DateTime.Today).Days : 0;
    }
}
