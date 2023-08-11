using System.ComponentModel.DataAnnotations;

namespace Library.API.Identity
{
    /// <summary>
    /// Represents user login credentials.
    /// </summary>
    public class Login
    {
        /// <summary>
        /// Gets or sets the email address for login.
        /// </summary>
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password for login.
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;
    }
}
