using AutoMapper;
using Library.API.Entities;
using Library.API.Models;

namespace Library.API.Profiles
{
    /// <summary>
    /// Represents a mapping profile for converting between <see cref="Book"/> and <see cref="BookDto"/> objects.
    /// </summary>
    public class BookProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookProfile"/> class.
        /// Configures mappings between <see cref="Book"/> and various DTOs.
        /// </summary>
        public BookProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
            CreateMap<BookForCreationDto, Book>();
            CreateMap<BookForUpdateDto, Book>();
            CreateMap<Book, BookForUpdateDto>();
        }
    }
}