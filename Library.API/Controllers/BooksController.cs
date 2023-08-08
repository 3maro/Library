using AutoMapper;
using Library.API.Entities;
using Library.API.Model;
using Library.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace Library.API.Controllers
{
    [Authorize]
    [Route("api/v{version:apiVersion}/books")]
    [ApiVersion("1")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        private readonly IMapper _mapper;

        public BooksController(IBookServices bookServices, IMapper mapper)
        {
            _bookServices = bookServices ?? throw new ArgumentNullException(nameof(bookServices));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAllBooks()
        {
            var bookEntities = await _bookServices.GetBooksAsync();

            return Ok(_mapper.Map<IEnumerable<BookDto>>(bookEntities));
        }

        // GET Book
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

        // POST
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

        // PUT
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


        // Patch
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

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(bookToPatch))
            {
                return BadRequest(ModelState);
            }

            _mapper.Map(bookToPatch,bookEntity);
            await _bookServices.SaveChangesAcny();

            var bookToReturn = _mapper.Map<BookDto>(bookEntity);

            return CreatedAtRoute("GetOneBook",
                new { bookid = bookToReturn.Id },
                bookToReturn
                );
        }

        // DELETE
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