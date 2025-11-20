namespace Tec.ProductCatalog.GetProducts.Core
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGetProductsServices(this IServiceCollection services)
        {
            services.AddScoped<IGetProductsController, GetProductsController>();
            services.AddScoped<IGetProductsInputPort, GetProductsInteractor>();
            services.AddScoped<IGetProductsOutputPort, GetProductsPresenter>();
            return services;
        }
    }

}
