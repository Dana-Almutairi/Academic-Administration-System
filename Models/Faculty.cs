using System.ComponentModel.DataAnnotations;

namespace Academic_Administration_System.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyID { get; set; }

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

        [Required]
        [StringLength(100)]
        public string Department { get; set; } = string.Empty;
    }
}