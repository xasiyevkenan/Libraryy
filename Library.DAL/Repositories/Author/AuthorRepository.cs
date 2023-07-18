
using Library.DAL.DataContext;

namespace Library.DAL.Repositories.Author
{
    public class AuthorRepository : EfCoreRepositoryAsync<Entities.Author>, IAuthorRepository
    {
        public AuthorRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }

        public async Task<ICollection<Entities.Author>> Test()
        {
            var result = (await base.GetAllAsync()).Where(x => x.Firstname == "Adolf").ToList();

            return result;
        }
    }
}
