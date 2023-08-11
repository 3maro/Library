using Library.API.Data;
using Library.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.API.Services
{
    /// <summary>
    /// Service class for managing books.
    /// </summary>
    public class BookServices : IBookServices
    {
        private readonly LibraryDbContext _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookServices"/> class.
        /// </summary>
        /// <param name="db">The <see cref="LibraryDbContext"/> for database operations.</param>
        public BookServices(LibraryDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        /// <summary>
        /// Retrieves a collection of books based on search criteria, and provides pagination metadata.
        /// </summary>
        /// <param name="name">The name of the book to filter by (optional).</param>
        /// <param name="searchQuery">The search query to filter books by (optional).</param>
        /// <param name="pageNumber">The current page number for pagination.</param>
        /// <param name="pageSize">The number of items per page for pagination.</param>
        public async Task<(IEnumerable<Book>, PaginationMetadata)> GetBooksAsync(
            string? name, string? searchQuery, int pageNumber, int pageSize)
        {
            // collection to start from
            var collection = _db.Books as IQueryable<Book>;

            if (!string.IsNullOrWhiteSpace(name))
            {
                name = name.Trim();
                collection = collection.Where(c => c.Title == name);
            }

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                searchQuery = searchQuery.Trim();
                collection = collection.Where(a => a.Title.Contains(searchQuery)
                    || (a.ShortDescription != null && a.ShortDescription.Contains(searchQuery)));
            }

            var totalItemCount = await collection.CountAsync();

            var paginationMetadata = new PaginationMetadata(
                totalItemCount, pageSize, pageNumber);

            var collectionToReturn = await collection.OrderBy(c => c.Title)
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            return (collectionToReturn, paginationMetadata);
        }

        /// <summary>
        /// Retrieves a book based on its unique identifier.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book to retrieve.</param>
        /// <returns>
        /// The retrieved <see cref="Book"/> object if found, or <c>null</c> if not found.
        /// </returns>
        public async Task<Book?> GetBookAsync(Guid bookId)
        {
            if (bookId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(bookId));
            }

            return await _db.Books
                                .Where(b => b.Id == bookId)
                                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Adds a new book to the database.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> object representing the book to add.</param>
        /// <remarks>
        /// The <paramref name="book"/> parameter should contain the details of the book to be added.
        /// After successful execution, the book will be added to the database.
        /// </remarks>
        public async Task AddBookAsync(Book book)
        {
            // the repository fills the id (instead of using identity columns)
            book.Id = Guid.NewGuid();

            await _db.Books.AddAsync(book);
        }

        /// <summary>
        /// Checks if a book with the specified unique identifier exists in the database.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book to check.</param>
        /// <returns>
        /// <c>true</c> if a book with the specified <paramref name="bookId"/> exists in the database;
        /// otherwise, <c>false</c>.
        /// </returns>
        public async Task<bool> BookExistsAsync(Guid bookId)
        {
            if (bookId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(bookId));
            }

            return await _db.Books.AnyAsync(b => b.Id == bookId);
        }

        /// <summary>
        /// Deletes a book from the database.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> object representing the book to delete.</param>
        /// <remarks>
        /// The <paramref name="book"/> parameter should contain the details of the book to be deleted.
        /// After successful execution, the book will be removed from the database.
        /// </remarks>
        public void DeleteBookAcync(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            _db.Books.Remove(book);
        }

        /// <summary>
        /// Saves changes made to the database asynchronously.
        /// </summary>
        /// <returns>
        /// <c>true</c> if changes were successfully saved; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method asynchronously saves any pending changes made to the database context.
        /// </remarks>
        public async Task<bool> SaveChangesAcny()
        {
            return (await _db.SaveChangesAsync() >= 0);
        }
    }
}
