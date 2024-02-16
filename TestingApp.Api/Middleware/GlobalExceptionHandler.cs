using Newtonsoft.Json;
using TestingApp.Domain.Exceptions;

namespace TestingApp.Api.Middleware;

public class GlobalExceptionHandler
{
    private readonly RequestDelegate _next;

    public GlobalExceptionHandler(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = GetStatusCode(exception);

        var errorResponse = new
        {
            error = new
            {
                code = context.Response.StatusCode,
                message = exception.Message
            }
        };

        var jsonResponse = JsonConvert.SerializeObject(errorResponse);
        await context.Response.WriteAsync(jsonResponse);

    }

    private static int GetStatusCode(Exception ex)
    {
        return ex switch
        {
            IncorrectCredentialsException or UserAlreadyExistsException => 400,
            AccessForbiddenException => 403,
            _ => 500,
        };
        ;

    }
}
