using InternsAdaptationService.Infrastructure.Handlers;
using InternsAdaptationService.Infrastructure.Interfaces.IHandlers;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Managers.Auth;
using InternsAdaptationService.Infrastructure.Managers.Internships;
using InternsAdaptationService.Infrastructure.Managers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Auth;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.EnumMappers;
using InternsAdaptationService.Infrastructure.Services.Auth;
using InternsAdaptationService.Infrastructure.Services.Internships;
using InternsAdaptationService.Infrastructure.Services.Patterns;

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
        services.AddTransient<IPatternPlanManager, PatternPlanManager>();
        services.AddTransient<IPatternPlanTaskManager, PatternPlanTaskManager>();
        services.AddTransient<IMentorInternManager, MentorInternManager>();

        return services;
    }

    private static IServiceCollection InjectMappers(this IServiceCollection services)
    {
        services.AddTransient<IRoleEnumMapper, RoleEnumMapper>();

        services.AddTransient<IUserMapper, UserMapper>();
        services.AddTransient<IPatternTaskMapper, PatternTaskMapper>();
        services.AddTransient<IPatternPlanMapper, PatternPlanMapper>();
        services.AddTransient<IPatternPlanTaskMapper, PatternPlanTaskMapper>();
        services.AddTransient<IMentorInternMapper, MentorInternMapper>();

        return services;
    }

    private static IServiceCollection InjectServices(this IServiceCollection services)
    {
        services.AddTransient<IAuthService, AuthService>();
        services.AddTransient<IPatternTaskService, PatternTaskService>();
        services.AddTransient<IPatternPlanService, PatternPlanService>();
        services.AddTransient<IPatternPlanTaskService, PatternPlanTaskService>();
        services.AddTransient<IMentorInternService, MentorInternService>();

        return services;
    }

    private static IServiceCollection InjectHandlers(this IServiceCollection services)
    {
        services.AddTransient<IErrorHandler, ErrorHandler>();

        return services;
    }
}
