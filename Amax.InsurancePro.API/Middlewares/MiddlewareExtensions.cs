
using Amax.InsurancePro.API.Authorization;

namespace Amax.InsurancePro.API.Middlewares;

public static class MiddlewareExtensions
{
    public static void RegisterMiddlewares(this WebApplication app)
    {
        // global error handler
        app.UseMiddleware<ErrorHandlerMiddleware>();

        // custom jwt auth middleware
        app.UseMiddleware<JwtMiddleware>();
    }
}

