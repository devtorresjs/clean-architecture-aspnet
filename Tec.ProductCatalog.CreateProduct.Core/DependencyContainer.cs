namespace Tec.ProductCatalog.CreateProduct.Core
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddcreateProductCoreService(this IServiceCollection services)
        {
            services.AddScoped<ICreateProductInputPort, CreateProductInteractor>();
            services.AddScoped<ICreateProductController, CreateProductController>();

            return services;
        }
    }

}
