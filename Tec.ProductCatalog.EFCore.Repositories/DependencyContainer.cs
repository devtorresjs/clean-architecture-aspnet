using Microsoft.Extensions.DependencyInjection;
using Tec.ProductCatalog.EFCore.Repositories.Options;
using Tec.ProductCatalog.EFCore.Repositories.Repositories;

namespace Tec.ProductCatalog.EFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddProductCatalogRepositories(
            this IServiceCollection services,
            Action<ProductCatalogDbOptions> configure)
        {
            ProductCatalogDbOptions Options = new();
            configure(Options);

            Action<DbContextOptionsBuilder> ConfigureOptions = options=>
            options.UseSqlServer(Options.ConnectionString);

            services.AddDbContext<GetProductDbContext>(ConfigureOptions);
            services.AddScoped<IGetProductRepository, GetProductRepository>();

       
            services.AddScoped<IGetProductsRepository, GetProductsRepository>();

            return services;
        }
    }

}
