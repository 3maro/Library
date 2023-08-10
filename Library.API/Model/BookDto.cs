
namespace Library.API.Model
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
    }
}
