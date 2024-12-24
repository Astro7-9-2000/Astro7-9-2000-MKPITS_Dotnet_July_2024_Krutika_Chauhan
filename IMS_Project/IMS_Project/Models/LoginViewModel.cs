
using System.ComponentModel.DataAnnotations;

namespace IMS_Project.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100 , ErrorMessage = "Password must be atleast 8 characters long" , MinimumLength = 8)]
        public string Password { get; set; }
    }
}
