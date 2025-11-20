namespace Tec.ProductCatalog.WebAPI
{
    public static class EndpointsMapper
    {
        public static IEndpointRouteBuilder UseTecProductCatalogEndpoints(
            this IEndpointRouteBuilder builder)
        {

            builder.UseGetProductEndpoints();
            builder.UseGetProductsEndpoints();

            return builder;
        }
    }

}
