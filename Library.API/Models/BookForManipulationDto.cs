using System.ComponentModel.DataAnnotations;

namespace Library.API.Models
{
    /// <summary>
    /// Represents a base data transfer object (DTO) for manipulating book information.
    /// </summary>
    public abstract class BookForManipulationDto
    {
        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        [Required(ErrorMessage = "Please enter the book title.")]
        [MaxLength(100, ErrorMessage = "The book title must be less than 100 characters.")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a short description of the book.
        /// </summary>
        [Required(ErrorMessage = "Please enter the book short description.")]
        [MaxLength(250, ErrorMessage = "The short description must be less than 250 characters.")]
        public string ShortDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the author's name of the book.
        /// </summary>
        [Required(ErrorMessage = "Please enter the author's name.")]
        public string Author { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the publish date of the book.
        /// </summary>
        [Required(ErrorMessage = "Please enter the publish date.")]
        public DateTime PublishDate { get; set; }
    }

}
