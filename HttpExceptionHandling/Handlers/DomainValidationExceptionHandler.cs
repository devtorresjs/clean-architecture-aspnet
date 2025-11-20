namespace HttpExceptionHandling.Handlers;
internal class DomainValidationExceptionHandler(
    ILogger<DomainValidationExceptionHandler> logger
    ) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext,
        Exception exception, CancellationToken cancellationToken)
    {
        bool Handled = false;

        if (exception is DomainValidationException DomainValidationException)
        {
            logger.LogWarning(DomainValidationException,
                Messages.DomainValidationErrorCountLogMessageTemplate,
                DomainValidationException.Errors?.Count ?? 0);

            var ProblemDetails = CreateValidationProblemDetails(
                DomainValidationException, httpContext);

            httpContext.Response.StatusCode = ProblemDetails.Status.Value;
            httpContext.Response.ContentType = "application/problem+json";

            var Json = JsonSerializer.Serialize(ProblemDetails);
            await httpContext.Response.WriteAsync(Json, cancellationToken);

            Handled = true;
        }

        return Handled;
    }

    private ValidationProblemDetails CreateValidationProblemDetails(
        DomainValidationException exception,
        HttpContext httpContext)
    {
        var Errors = exception.Errors
            .GroupBy(e => e.PropertyName)
            .ToDictionary(g => g.Key,
            g => g.Select(e => e.ErrorMessage).ToArray());

        var ProblemDetails = new ValidationProblemDetails(Errors)
        {
            Type = "urn:exception:domain-validation",
            Status = StatusCodes.Status400BadRequest,
            Title = Messages.DomainValidationTitle,
            Instance = httpContext.Request.Path
        };

        if (!string.IsNullOrWhiteSpace(exception.Message))
        {
            ProblemDetails.Detail = exception.Message;
        }

        return ProblemDetails;
    }
}
