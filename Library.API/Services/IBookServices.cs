using Library.API.Entities;

namespace Library.API.Services
{
    /// <summary>
    /// Represents a service interface for managing books.
    /// </summary>
    public interface IBookServices
    {
        /// <summary>
        /// Retrieves a collection of books based on specified criteria and pagination settings.
        /// </summary>
        /// <param name="name">The optional name to filter by.</param>
        /// <param name="searchQuery">The optional search query to filter by.</param>
        /// <param name="pageNumber">The page number to retrieve.</param>
        /// <param name="pageSize">The number of items per page.</param>
        /// <returns>
        /// A tuple containing the collection of Book objects and pagination metadata.
        /// </returns>
        Task<(IEnumerable<Book>, PaginationMetadata)> GetBooksAsync(string? name, string? searchQuery, int pageNumber, int pageSize);

        /// <summary>
        /// Retrieves a single book based on its unique identifier.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book.</param>
        /// <returns>The retrieved Book object, or null if not found.</returns>
        Task<Book?> GetBookAsync(Guid bookId);

        /// <summary>
        /// Adds a new book to the database.
        /// </summary>
        /// <param name="book">The Book object to be added.</param>
        Task AddBookAsync(Book book);

        /// <summary>
        /// Deletes a book from the database.
        /// </summary>
        /// <param name="book">The Book object to be deleted.</param>
        void DeleteBookAcync(Book book);

        /// <summary>
        /// Saves changes made to the database asynchronously.
        /// </summary>
        /// <returns>true if changes were saved successfully; otherwise, false.</returns>
        Task<bool> SaveChangesAcny();

        /// <summary>
        /// Checks if a book with the specified identifier exists in the database.
        /// </summary>
        /// <param name="bookId">The unique identifier of the book to check.</param>
        /// <returns>true if the book exists; otherwise, false.</returns>
        Task<bool> BookExistsAsync(Guid bookId);
    }

}
