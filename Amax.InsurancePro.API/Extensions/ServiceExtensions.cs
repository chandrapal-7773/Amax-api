using Amax.InsurancePro.Application;

namespace Amax.InsurancePro.API.Extensions;

public static class ServiceExtensions
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.RegisterApplicationServices(configuration);


    }
}

