namespace Tec.ProductCatalog.GetProduct.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddGetProductServices(this IServiceCollection services)
        {

            services.AddGetProductCoreService();
            return services;
        }
    }

}
