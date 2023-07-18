
using Library.DAL.Entities;
using Library.DAL.Repositories.Contracts;

namespace Library.DAL.Repositories.Author
{
    public interface IAuthorRepository : IRepositoryAsync<Entities.Author>
    {
        Task<ICollection<Entities.Author>> Test();
    }
}
