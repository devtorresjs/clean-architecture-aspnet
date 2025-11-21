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

            Action<DbContextOptionsBuilder> ConfigureOptions = options =>
            options.UseSqlServer(Options.ConnectionString);

            services.AddProductCatalogRepositories(ConfigureOptions);

            return services;
        }
        public static IServiceCollection AddProductCatalogRepositories(
            this IServiceCollection services,
            Action<DbContextOptionsBuilder> configure)
        {
            services.AddDbContext<ProductDbContext>(configure);
            services.AddScoped<IGetProductRepository, GetProductRepository>();

            services.AddScoped<IGetProductsRepository, GetProductsRepository>();

            services.AddScoped<ICreateProductRepository, CreateProductRepository>();

            return services;
        }
    }

}
