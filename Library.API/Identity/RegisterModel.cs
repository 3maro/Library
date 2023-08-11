using System.ComponentModel.DataAnnotations;

namespace Library.API.Identity
{
    /// <summary>
    /// Represents a model for user registration.
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// Gets or sets the email address of the user for registration.
        /// </summary>
        [Required(ErrorMessage = "The Email field is required.")]
        [StringLength(50, ErrorMessage = "The Email field must be at most 50 characters.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password for the user's registration.
        /// </summary>
        [Required(ErrorMessage = "The Password field is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The Password field must be between 5 and 100 characters.")]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the confirmation password for the user's registration.
        /// </summary>
        [Required(ErrorMessage = "The Confirm Password field is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The Confirm Password field must be between 5 and 100 characters.")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }

}