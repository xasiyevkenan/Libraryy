
using Library.BLL.Dtos.Book;
using Library.BLL.Services.Contracts;
using Library.DAL.Entities;
using Library.DAL.Repositories.Book;
using Library.DAL.Repositories.Contracts;

namespace Library.BLL.Services
{
    public class BookManager : IBookService
    {
        public readonly IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task CreateBook(BookCreateDto bookCreateDto)
        {
            var book = new Book()
            {
                Title = bookCreateDto.Title,
                Description = bookCreateDto.Description,
                CreatedAt = DateTime.Now,
            };

            await _bookRepository.AddAsync(book);
        }

        public async Task<BookDto> GetBook(int? id)
        {
            var book = await _bookRepository.GetAsync(id);

            if (book == null) return new BookDto();

            var bookDto = new BookDto()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
            };

            return bookDto;
        }

        public async Task<ICollection<BookDto>> GetBooks()
        {
            var books = await _bookRepository.GetAllAsync();

            var bookDtos = new List<BookDto>();

            foreach (var book in books)
            {
                bookDtos.Add(new BookDto
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                });
            }

            return bookDtos;
        }

        public async Task<ICollection<BookDto>> Test()
        {
            var books = await _bookRepository.Test();

            var bookDtos = new List<BookDto>();

            foreach (var book in books)
            {
                bookDtos.Add(new BookDto
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                });
            }

            return bookDtos;
        }
    }
}
