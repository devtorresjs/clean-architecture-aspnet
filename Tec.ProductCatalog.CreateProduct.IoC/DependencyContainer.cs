namespace Tec.ProductCatalog.CreateProduct.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddCreateProductServices(this IServiceCollection services)
        {
            services.AddcreateProductCoreService();
            services.AddCreateProductSpecifications();

            return services;
        }
    }

}
