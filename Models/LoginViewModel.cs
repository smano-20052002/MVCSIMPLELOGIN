using System.ComponentModel.DataAnnotations;

namespace SimpleLoginPage1.Models
{
    public class LoginViewModel{
       
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Invalid Email format")]
        public string? Email { get; set; }

        [Required(ErrorMessage  = "Password is required")]
        [DataType(DataType.Password,ErrorMessage = "Invalid Password format")]
        public string? Password { get; set; }
    }
}