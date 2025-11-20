namespace Tec.ProductCatalog.WebAPI
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddTecProductCalogServices(
            this IServiceCollection services,
            Action<ProductCatalogDbOptions> configureDbOptions)
        {
            services.AddProductCatalogRepositories(configureDbOptions);

            services.AddGetProductServices();
            services.AddGetProductsServices();
            services.AddCreateProductServices();

            return services;
        }
    }

}
