using InternsAdaptationService.Data.Interfaces.IRepositories;
using InternsAdaptationService.Data.Repositories;
using InternsAdaptationService.Infrastructure.Handlers;
using InternsAdaptationService.Infrastructure.Interfaces.IHandlers;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices;
using InternsAdaptationService.Infrastructure.Managers;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers;
using InternsAdaptationService.Infrastructure.Mappers.EnumMappers;
using InternsAdaptationService.Infrastructure.Services;

namespace InternsAdaptationService.API.Extensions;

public static class InfrastructureLayerProvider
{
    public static IServiceCollection InjectInfrastructureLayer(this IServiceCollection services)
    {
        services.InjectManagers();
        services.InjectMappers();
        services.InjectServices();
        services.InjectHandlers();

        return services;
    }

    private static IServiceCollection InjectManagers(this IServiceCollection services)
    {
        services.AddTransient<IAuthManager, AuthManager>();
        services.AddTransient<IPatternTaskManager, PatternTaskManager>();

        return services;
    }

    private static IServiceCollection InjectMappers(this IServiceCollection services)
    {
        services.AddTransient<IRoleEnumMapper, RoleEnumMapper>();
        services.AddTransient<IUserMapper, UserMapper>();
        services.AddTransient<IPatternTaskMapper, PatternTaskMapper>();

        return services;
    }

    private static IServiceCollection InjectServices(this IServiceCollection services)
    {
        services.AddTransient<IAuthService, AuthService>();
        services.AddTransient<IPatternTaskService, PatternTaskService>();

        return services;
    }

    private static IServiceCollection InjectHandlers(this IServiceCollection services)
    {
        services.AddTransient<IErrorHandler, ErrorHandler>();

        return services;
    }
}
