
using Library.DAL.Repositories;
using Library.DAL.Repositories.Author;
using Library.DAL.Repositories.Book;
using Library.DAL.Repositories.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Library.DAL
{
    public static class DataAccessLayerServiceRegistration
    {
        public static IServiceCollection AddDalServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();

            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }
    }
}
