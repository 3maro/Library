using System.ComponentModel.DataAnnotations;

namespace Library.API.Models
{
    /// <summary>
    /// Represents a data transfer object (DTO) for a quote.
    /// </summary>
    public class QuoteDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the quote.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the content of the quote.
        /// </summary>
        [Required]
        [MaxLength(250)]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the book associated with the quote.
        /// </summary>
        [MaxLength(100)]
        public string BookName { get; set; } = string.Empty;
    }
}