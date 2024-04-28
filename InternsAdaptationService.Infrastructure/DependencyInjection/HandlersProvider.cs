using InternsAdaptationService.Infrastructure.Handlers;
using InternsAdaptationService.Infrastructure.Interfaces.IHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace InternsAdaptationService.Infrastructure.DependencyInjection;

public static class HandlersProvider
{
    public static IServiceCollection InjectHandlers(this IServiceCollection services)
    {
        services.AddTransient<IErrorHandler, ErrorHandler>();

        return services;
    }
}
