﻿using System.ComponentModel.DataAnnotations;

namespace Library.API.Entities
{
    /// <summary>
    /// Represents a book entity.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the unique identifier of the book.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a short description of the book.
        /// </summary>
        [MaxLength(250)]
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