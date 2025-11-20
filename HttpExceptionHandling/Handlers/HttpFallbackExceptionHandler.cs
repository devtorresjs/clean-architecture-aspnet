namespace HttpExceptionHandling.Handlers;
internal class HttpFallbackExceptionHandler(
    ILogger<HttpFallbackExceptionHandler> logger,
    IHostEnvironment environment) : IHttpFallbackExceptionHandler
{
    public async Task HandleAsync(HttpContext httpContext,
        CancellationToken cancellationToken)
    {
        var Feature = httpContext.Features.Get<IExceptionHandlerPathFeature>();
        Exception Exception = Feature?.Error;

        if (Exception != null)
        {
            logger.LogError(Exception,
                Messages.UnhandledExceptionLogMessageTemplate,
                httpContext.TraceIdentifier);

            ProblemDetails ProblemDetails = CreateProblemDetails(Exception,
                httpContext);

            httpContext.Response.StatusCode = ProblemDetails.Status.Value;
            httpContext.Response.ContentType = "application/problem+json";

            var Json = JsonSerializer.Serialize(ProblemDetails);
            await httpContext.Response.WriteAsync(Json, cancellationToken);
        }
    }

    private ProblemDetails CreateProblemDetails(
        Exception exception, HttpContext httpContext)
    {
        var ProblemDetails = new ProblemDetails
        {
            Type = "urn:exception:unhandled",
            Status = exception.ToHttpStatusCode(),
            Title = exception.ToHttpTitle(),
            Instance = httpContext.Request.Path
        };

        if (environment.IsDevelopment())
        {
            ProblemDetails.Detail = exception.Message;
            ProblemDetails.Extensions["stacktrace"] = exception.StackTrace;
            ProblemDetails.Extensions["innerException"] =
                exception.InnerException?.Message;
        }
        else
        {
            ProblemDetails.Detail = Messages.UnhhandledExceptionDetailMessage;
        }

        ProblemDetails.Extensions["traceId"] = httpContext.TraceIdentifier;

        return ProblemDetails;
    }
}
