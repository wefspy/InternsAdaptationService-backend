using InternsAdaptationService.Infrastructure.Interfaces.IServices;
using InternsAdaptationService.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InternsAdaptationService.Infrastructure.DependencyInjection;

public static class ServicesProvider
{
    public static IServiceCollection InjectServices(this IServiceCollection services)
    {
        services.AddTransient<IAuthService, AuthService>();

        return services;
    }
}
