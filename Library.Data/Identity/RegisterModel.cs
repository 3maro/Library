using System.ComponentModel.DataAnnotations;

namespace Library.API.Identity
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [StringLength(50, ErrorMessage = "The Email field must be at most 50 characters.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Password field is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The Password field must be between 5 and 100 characters.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Confirm Password field is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The Confirm Password field must be between 5 and 100 characters.")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}