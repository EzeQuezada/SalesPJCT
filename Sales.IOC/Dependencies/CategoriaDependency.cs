


using Microsoft.Extensions.DependencyInjection;
using Sales.Core.Interfaces;
using Sales.Infraestructure.Repositories;


namespace Sales.IOC.Dependencies
{
    public static class CategoriaDependency
    {
        public static void AddCategoriaDependency(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            //La dependencia del app service

        }
    }
}
