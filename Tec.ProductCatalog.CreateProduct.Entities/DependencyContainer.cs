namespace Tec.ProductCatalog.CreateProduct.Entities
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddCreateProductSpecifications(this IServiceCollection services)
        {
            services.AddScoped<IDomainSpecification<CreateProductDto>,
           CreateProductDtoSpecification>();

            services.AddDomainSpecificationsValidator();

            return services;
        }
    }

}
