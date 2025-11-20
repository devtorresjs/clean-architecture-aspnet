namespace Tec.ProductCatalog.CreateProduct.Rest.Mappings
{
    public static class EndpointsMapper
    {
        public static IEndpointRouteBuilder UseCreateProductEndpoints(
            this IEndpointRouteBuilder builder)
        {

            builder.MapPost(Patterns.CreateProduct,
                async (CreateProductDto product,
                    ICreateProductController controller) =>
                    TypedResults.Ok(await controller.CreateProductAsync(product)))
                .Produces<int>();

            return builder;
        }
    }

}
