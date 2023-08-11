using Library.API.Data;
using Library.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.API.Services
{
    /// <summary>
    /// Represents a service for managing quotes.
    /// </summary>
    public class QuoteServices : IQuoteServices
    {
        private readonly LibraryDbContext _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteServices"/> class.
        /// </summary>
        /// <param name="db">The database context.</param>
        public QuoteServices(LibraryDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        /// <summary>
        /// Retrieves a collection of quotes from the database.
        /// </summary>
        /// <returns>An asynchronous task that returns the collection of quotes.</returns>
        public async Task<IEnumerable<Quote>> GetQuotesAsync()
        {
            return await _db.Quotes.OrderBy(q => q.Id).ToListAsync();
        }

        /// <summary>
        /// Adds a new quote to the database.
        /// </summary>
        /// <param name="quote">The quote to be added.</param>
        /// <returns>An asynchronous task representing the operation.</returns>
        public async Task AddQuoteAsync(Quote quote)
        {
            // the repository fills the id (instead of using identity columns)
            quote.Id = Guid.NewGuid();

            await _db.Quotes.AddAsync(quote);
        }
    }

}
