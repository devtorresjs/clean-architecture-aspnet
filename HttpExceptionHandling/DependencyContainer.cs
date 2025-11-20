namespace HttpExceptionHandling;
public static class DependencyContainer
{
    public static IServiceCollection AddHttpDomainValidationExceptionHandler(
        this IServiceCollection services)
    {
        services.AddExceptionHandler<DomainValidationExceptionHandler>();

        return services;
    }

    public static IServiceCollection AddHttpFallbackExceptionHandler(
        this IServiceCollection services)
    {
        services.AddSingleton<IHttpFallbackExceptionHandler,
            HttpFallbackExceptionHandler>();

        return services;
    }

    public static IApplicationBuilder UseExceptionHandlerWithFallbackExceptionHandling(
        this IApplicationBuilder app)
    {
        app.UseExceptionHandler(errorApp =>
        {
            errorApp.Run(async context =>
            {
                var FallbackHandler = context.RequestServices
                .GetRequiredService<IHttpFallbackExceptionHandler>();

                await FallbackHandler.HandleAsync(context,
                    context.RequestAborted);
            });
        });

        return app;
    }
}

