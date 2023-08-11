namespace Library.API.Models
{
    /// <summary>
    /// Represents a data transfer object (DTO) for a book.
    /// </summary>
    public class BookDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the book.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a short description of the book.
        /// </summary>
        public string ShortDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the publish date of the book.
        /// </summary>
        public DateTime PublishDate { get; set; }
    }

}
