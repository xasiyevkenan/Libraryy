
using Library.BLL.Dtos.Book;

namespace Library.BLL.Services.Contracts
{
    public interface IBookService
    {
        Task<ICollection<BookDto>> GetBooks();
        Task<BookDto> GetBook(int? id);
        Task CreateBook(BookCreateDto bookCreateDto);
        Task<ICollection<BookDto>> Test();
    }
}
