using CleanArch.Application.Interfaces;
using CleanArch.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
namespace CleanArch.API
{
    public static class ServiceExtenstions
    {
        public static void AddApplication(this IServiceCollection service)
        {
            service.AddTransient<IUnitOfWork, UnitOfWork>();
            service.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
