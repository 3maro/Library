using AutoMapper;
using Library.API.Entities;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Library.API.Controllers
{
    /// <summary>
    /// Controller for managing books.
    /// </summary>
    [Authorize]
    [Route("api/books")]
    //[Route("api/v{version:apiVersion}/books")]
    //[ApiVersion("1")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        private readonly IMapper _mapper;
        const int maxBooksPageSize = 20;

        /// <summary>
        /// BooksController Contractor
        /// </summary>
        public BooksController(IBookServices bookServices, IMapper mapper)
        {
            _bookServices = bookServices ?? throw new ArgumentNullException(nameof(bookServices));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// GET all books.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAllBooks(
                string? name, string? searchQuery, int pageNumber =1, int pageSize = 4)
        {
            if (pageSize > maxBooksPageSize)
            {
                pageSize = maxBooksPageSize;
            }

            var (bookEntities, paginationMetadata) = await _bookServices.GetBooksAsync(name, searchQuery, pageNumber, pageSize);

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<BookDto>>(bookEntities));
        }

        /// <summary>
        /// GET a specific book by its ID.
        /// </summary>
        /// <param name="bookId">The ID of the book to retrieve.</param>
        [HttpGet("{bookid}", Name = "GetOneBook")]
        public async Task<ActionResult<BookDto>> GetOneBook(Guid bookId)
        {
            var bookEntity = await _bookServices.GetBookAsync(bookId);
            if (bookEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<BookDto>(bookEntity));
        }

        /// <summary>
        /// Creates a new book.
        /// </summary>
        /// <param name="book">The <see cref="BookForCreationDto"/> representing the book to create.</param>
        [HttpPost]
        public async Task<ActionResult<BookDto>> CreateBook(BookForCreationDto book)
        {
            var finalBookEntity = _mapper.Map<Book>(book);

            await _bookServices.AddBookAsync(finalBookEntity);

            await _bookServices.SaveChangesAcny();

            var createdBookerestToReturn = _mapper.Map<BookDto>(finalBookEntity);

            return CreatedAtRoute("GetOneBook",
                new { bookid = finalBookEntity.Id },
                createdBookerestToReturn
                );
        }

        /// <summary>
        /// Full Update an existing book.
        /// </summary>
        /// <param name="bookId">The ID of the book to update.</param>
        /// <param name="book">The <see cref="BookForUpdateDto"/> containing updated book information.</param>
        [HttpPut("{bookid}")]
        public async Task<ActionResult<BookDto>> UpdateBook(Guid bookId, BookForUpdateDto book)
        {
            var bookEntity = await _bookServices.GetBookAsync(bookId);
            if (bookEntity == null)
            {
                return NotFound();
            }
            var bookToUpdate = _mapper.Map(book, bookEntity);
            await _bookServices.SaveChangesAcny();

            var bookToReturn = _mapper.Map<BookDto>(bookToUpdate);

            return CreatedAtRoute("GetOneBook",
                new { bookid = bookToReturn.Id },
                bookToReturn
                );
        }


        /// <summary>
        /// Partially updates an existing book.
        /// </summary>
        /// <param name="bookId">The ID of the book to partially update.</param>
        /// <param name="patchDocument">The <see cref="JsonPatchDocument{BookForUpdateDto}"/> containing partial update instructions.</param>
        [HttpPatch("{bookid}")]
        public async Task<ActionResult<BookDto>> PartiallyUpdateBook(Guid bookId, JsonPatchDocument<BookForUpdateDto> patchDocument)
        {
            var bookEntity = await _bookServices.GetBookAsync(bookId);
            if (bookEntity == null)
            {
                return NotFound();
            }

            var bookToPatch = _mapper.Map<BookForUpdateDto>(bookEntity);

            patchDocument.ApplyTo(bookToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(bookToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(bookToPatch, bookEntity);
            await _bookServices.SaveChangesAcny();

            var bookToReturn = _mapper.Map<BookDto>(bookEntity);

            return CreatedAtRoute("GetOneBook",
                new { bookid = bookToReturn.Id },
                bookToReturn
                );
        }

        /// <summary>
        /// Deletes a book.
        /// </summary>
        /// <param name="bookid">The ID of the book to delete.</param>
        [HttpDelete("{bookid}")]
        public async Task<ActionResult> Delete(Guid bookid)
        {
            var bookEntity = await _bookServices.GetBookAsync(bookid);
            if (bookEntity == null)
            {
                return NotFound();
            }

            _bookServices.DeleteBookAcync(bookEntity);
            await _bookServices.SaveChangesAcny();

            return NoContent();
        }
    }
}