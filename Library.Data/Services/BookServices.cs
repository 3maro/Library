using Library.API.Entities;
using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.API.Services
{
    public class BookServices : IBookServices
    {
        private readonly LibraryDbContext _context;

        public BookServices(LibraryDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _context.Books
                                    .OrderBy(b => b.Title)
                                    .ToListAsync();
        }

        public async Task<Book?> GetBookAsync(Guid bookId)
        {
            if (bookId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(bookId));
            }

            return await _context.Books
                                    .Where(b => b.Id == bookId)
                                    .FirstOrDefaultAsync();
        }

        public async Task AddBookAsync(Book book)
        {
            // the repository fills the id (instead of using identity columns)
            book.Id = Guid.NewGuid();

            await _context.Books.AddAsync(book);
        }

        public async Task<bool> BookExistsAsync(Guid bookId)
        {
            if (bookId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(bookId));
            }

            return await _context.Books.AnyAsync(b => b.Id == bookId);
        }

        public void DeleteBookAcync(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            _context.Books.Remove(book);
        }


        public async Task<bool> SaveChangesAcny()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
