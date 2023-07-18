
using Library.DAL.DataContext;
using Library.DAL.Repositories.Book;

namespace Library.DAL.Repositories.Book
{
    public class BookRepository : EfCoreRepositoryAsync<Entities.Book>, IBookRepository
    {
        public BookRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<ICollection<Entities.Book>> Test()
        {
            var result = (await base.GetAllAsync()).Where(x => x.Description == "Roman").ToList();

            return result;
        }
    }
}
