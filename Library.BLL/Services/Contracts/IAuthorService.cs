
using Library.BLL.Dtos.Author;

namespace Library.BLL.Services.Contracts
{
    public interface IAuthorService
    {
        Task<ICollection<AuthorDto>> GetAuthors();
        Task<AuthorDto> GetAuthor(int? id);
        Task CreateAuthor(AuthorCreateDto authorCreateDto);
        Task<ICollection<AuthorDto>> Test();
    }
}
