using Library.API.Entities;

namespace Library.API.Services
{
    public interface IBookServices
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book?> GetBookAsync(Guid bookId);
        Task AddBookAsync(Book book);
        void DeleteBookAcync(Book book);

        Task<bool> SaveChangesAcny();
        Task<bool> BookExistsAsync(Guid bookId);
    }
}
