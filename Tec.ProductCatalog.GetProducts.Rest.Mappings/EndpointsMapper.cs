
public static class EndpointsMapper
    {
        public static IEndpointRouteBuilder UseGetProductsEndpoints(
        this IEndpointRouteBuilder builder)
        {
        builder.MapGet(Patterns.GetProductsRouteBase,
            async ([AsParameters]
                GetProductsParametersDto parameters,
                IGetProductsController controller) =>
            TypedResults.Ok(await controller.GetProductsAsync(parameters)))
        .Produces<GetProductsResponseDto>();

        return builder;
        }
    }
