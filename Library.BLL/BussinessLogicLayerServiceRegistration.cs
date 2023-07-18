
using Library.BLL.Services;
using Library.BLL.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Library.BLL
{
    public static class BussinessLogicLayerServiceRegistration
    {
        public static IServiceCollection AddBllServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorManager>();

            services.AddScoped<IBookService, BookManager>();

            return services;
        }
    }
}
