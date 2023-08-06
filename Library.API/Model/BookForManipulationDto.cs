using System.ComponentModel.DataAnnotations;

namespace Library.API.Model
{
    public abstract class BookForManipulationDto
    {
        [Required(ErrorMessage = "Please enter the book title.")]
        [MaxLength(100, ErrorMessage = "The book title must be less than 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the book short description.")]
        [MaxLength(250, ErrorMessage = "The short description must be less than 250 characters.")]
        public string ShortDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the author's name.")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the publish date.")]
        public DateTime PublishDate { get; set; }
    }
}
