using InternsAdaptationService.Infrastructure.Interfaces.IManagers;
using InternsAdaptationService.Infrastructure.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace InternsAdaptationService.Infrastructure.DependencyInjection;

public static class ManagersProvider
{
    public static IServiceCollection InjectManagers(this IServiceCollection services)
    {
        services.AddTransient<IAuthManager, AuthManager>();

        return services;
    }
}
