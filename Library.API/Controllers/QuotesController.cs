using AutoMapper;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    /// <summary>
    /// Controller for managing quotes.
    /// </summary>
    [Route("api/quotes")]
    [ApiController]
    [Authorize]
    public class QuotesController : ControllerBase
    {
        private readonly IQuoteServices _quoteServices;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesController"/> class.
        /// </summary>
        public QuotesController(IQuoteServices quoteServices, IMapper mapper)
        {
            _quoteServices = quoteServices;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves a collection of quotes.
        /// </summary>
        /// <returns>
        /// A collection of <see cref="QuoteDto"/> objects representing quotes.
        /// </returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuoteDto>>> GetQuotes()
        {
            var quoteEntites = await _quoteServices.GetQuotesAsync();
            return Ok(_mapper.Map<IEnumerable<QuoteDto>>(quoteEntites));
        }
    }
}
