using Library.API.Entities;

namespace Library.API.Services
{
    /// <summary>
    /// Represents a service interface for managing quotes.
    /// </summary>
    public interface IQuoteServices
    {
        /// <summary>
        /// Retrieves a collection of quotes from a data source.
        /// </summary>
        /// <returns>An asynchronous task that returns the collection of quotes.</returns>
        Task<IEnumerable<Quote>> GetQuotesAsync();

        /// <summary>
        /// Adds a new quote to a data source.
        /// </summary>
        /// <param name="quote">The quote to be added.</param>
        /// <returns>An asynchronous task representing the operation.</returns>
        Task AddQuoteAsync(Quote quote);
    }

}
