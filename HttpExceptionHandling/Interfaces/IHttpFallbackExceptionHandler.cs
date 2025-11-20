namespace HttpExceptionHandling.Interfaces;
public interface IHttpFallbackExceptionHandler
{
    Task HandleAsync(HttpContext httpContext, CancellationToken cancellationToken);
}
