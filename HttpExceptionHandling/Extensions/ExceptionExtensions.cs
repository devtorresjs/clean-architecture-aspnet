using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpExceptionHandling.Extensions;
internal static class ExceptionExtensions
{
    public static int ToHttpStatusCode(this Exception exception) =>
        exception switch
        {
            ArgumentNullException => StatusCodes.Status400BadRequest,
            ArgumentException => StatusCodes.Status400BadRequest,
            InvalidOperationException => StatusCodes.Status400BadRequest,
            UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
            NotImplementedException => StatusCodes.Status501NotImplemented,
            TimeoutException => StatusCodes.Status408RequestTimeout,
            _ => StatusCodes.Status500InternalServerError
        };

    public static string ToHttpTitle(this Exception exception) =>
        exception switch
        {
            ArgumentNullException => Messages.BadRequestExceptionTitle,
            ArgumentException => Messages.BadRequestExceptionTitle,
            InvalidOperationException => Messages.BadRequestExceptionTitle,
            UnauthorizedAccessException => Messages.UnauthorizedAccessExceptionTitle,
            NotImplementedException => Messages.NotImplementedExceptionTitle,
            TimeoutException => Messages.TimeoutExceptionTitle,
            _ => Messages.UnknownExceptionTitle
        };
}
