
using Library.BLL.Dtos.Author;
using Library.BLL.Services.Contracts;
using Library.DAL.Entities;
using Library.DAL.Repositories.Author;
using Library.DAL.Repositories.Contracts;

namespace Library.BLL.Services
{
    public class AuthorManager : IAuthorService
    {
        public readonly IAuthorRepository _authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task CreateAuthor(AuthorCreateDto authorCreateDto)
        {
            var author = new Author()
            {
                Firstname = authorCreateDto.Firstname,
                Lastname = authorCreateDto.Lastname,
                CreatedAt = DateTime.Now,
            };

            await _authorRepository.AddAsync(author);
        }

        public async Task<AuthorDto> GetAuthor(int? id)
        {
            var author = await _authorRepository.GetAsync(id);

            if (author == null) return new AuthorDto();

            var authorDto = new AuthorDto()
            {
                Id = author.Id,
                Firstname = author.Firstname,
                Lastname = author.Lastname,
            };

            return authorDto;
        }

        public async Task<ICollection<AuthorDto>> GetAuthors()
        {
            var authors = await _authorRepository.GetAllAsync();

            var authorDtos = new List<AuthorDto>();

            foreach (var author in authors)
            {
                authorDtos.Add(new AuthorDto
                {
                    Id = author.Id,
                    Firstname = author.Firstname,
                    Lastname = author.Lastname,
                });
            }

            return authorDtos;
        }

        public async Task<ICollection<AuthorDto>> Test()
        {
            var authors = await _authorRepository.Test();

            var authorDtos = new List<AuthorDto>();

            foreach (var author in authors)
            {
                authorDtos.Add(new AuthorDto
                {
                    Id = author.Id,
                    Firstname = author.Firstname,
                    Lastname = author.Lastname,
                });
            }

            return authorDtos;
        }
    }
}
