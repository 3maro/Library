using AutoMapper;
using Library.API.Entities;
using Library.API.Models;

namespace Library.API.Profiles
{
    /// <summary>
    /// Represents a mapping profile for converting between <see cref="Quote"/> and <see cref="QuoteDto"/>.
    /// </summary>
    public class QuoteProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteProfile"/> class.
        /// Configures mappings between <see cref="Quote"/> and <see cref="QuoteDto"/>.
        /// </summary>
        public QuoteProfile()
        {
            CreateMap<Quote, QuoteDto>();
        }
    }
}
