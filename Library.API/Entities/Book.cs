using System.ComponentModel.DataAnnotations;

namespace Library.API.Entities
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(250)]
        public string ShortDescription { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public DateTime PublishDate { get; set; }
    }
}