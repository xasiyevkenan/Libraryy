
using Library.DAL.Entities;
using Library.DAL.Repositories.Contracts;

namespace Library.DAL.Repositories.Book
{
    public interface IBookRepository : IRepositoryAsync<Entities.Book>
    {
        Task<ICollection<Entities.Book>> Test();
    }
}
