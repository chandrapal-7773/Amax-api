namespace Amax.InsurancePro.API.Authorization;

using Amax.InsurancePro.Application.Services.Utilities;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;

    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IJwtUtils jwtUtils)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        var user = jwtUtils.ValidateJwtToken(token: token);
        if (user != null)
        {
            // attach user to context on successful jwt validation
            context.Items["User"] = user;
        }

        await _next(context);
    }
}