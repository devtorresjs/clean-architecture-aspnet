namespace Tec.ProductCatalog.GetProduct.Rest.Mappings
{
    public static class EndpointsMapper
    {
        public static IEndpointRouteBuilder UseGetProductEndpoints(
        this IEndpointRouteBuilder builder)
        {
            builder.MapGet(Patterns.GetProduct,
           async (int id, IGetProductController controller) =>
               TypedResults.Ok(await controller.GetProductAsync(id)))
           .Produces<GetProductDto>();
            return builder;
        }
    }
}
