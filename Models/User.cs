using System.ComponentModel.DataAnnotations;

namespace SimpleLoginPage1.Models
{
    public class User{
        [Key]
        public int UserId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? MobileNumber { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}