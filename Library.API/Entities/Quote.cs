﻿using System.ComponentModel.DataAnnotations;

namespace Library.API.Entities
{
    /// <summary>
    /// Represents a quote with content.
    /// </summary>
    public class Quote
    {
        /// <summary>
        /// Gets or sets the unique identifier for the quote.
        /// </summary>
        [Key]
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