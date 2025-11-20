namespace Tec.ProductCatalog.GetProduct.Core
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGetProductCoreService(this IServiceCollection services)
        {
            services.AddScoped<IGetProductController, GetProductController>();
            services.AddScoped<IGetProductInputPort, GetProductInteractor>();

            return services;
        }
    }

}
