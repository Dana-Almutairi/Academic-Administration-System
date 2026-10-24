using System.ComponentModel.DataAnnotations;

namespace Academic_Administration_System.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [StringLength(20)]
        public string? PhoneNumber { get; set; }
    }
}