using System.ComponentModel.DataAnnotations;

namespace Library.API.Entities
{
    public class Quote
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Content { get; set; } = string.Empty;
    }
}