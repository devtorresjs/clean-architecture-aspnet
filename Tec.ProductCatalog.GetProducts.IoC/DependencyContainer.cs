namespace Tec.ProductCatalog.GetProducts.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGroupServices(this IServiceCollection services)
        {
            services.AddGetProductsServices();

            return services;
        }
    }

}
