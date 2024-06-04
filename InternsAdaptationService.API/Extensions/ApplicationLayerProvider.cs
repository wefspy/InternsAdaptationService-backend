using InternsAdaptationService.Application.Handlers;
using InternsAdaptationService.Application.Interfaces.IHandlers;
using InternsAdaptationService.Application.Interfaces.IManagers.Auth;
using InternsAdaptationService.Application.Interfaces.IManagers.Internships;
using InternsAdaptationService.Application.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Application.Interfaces.IManagers.Patterns.Children;
using InternsAdaptationService.Application.Interfaces.IManagers.User;
using InternsAdaptationService.Application.Interfaces.IServices.Auth;
using InternsAdaptationService.Application.Interfaces.IServices.Internships;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns.Children;
using InternsAdaptationService.Application.Managers.Auth;
using InternsAdaptationService.Application.Managers.Internships;
using InternsAdaptationService.Application.Managers.Patterns;
using InternsAdaptationService.Application.Managers.Patterns.Children;
using InternsAdaptationService.Application.Managers.User;
using InternsAdaptationService.Application.Services.Auth;
using InternsAdaptationService.Application.Services.Internships;
using InternsAdaptationService.Application.Services.Patterns;
using InternsAdaptationService.Application.Services.Patterns.Children;
using InternsAdaptationService.Application.Services.User;


namespace InternsAdaptationService.API.Extensions;

public static class ApplicationLayerProvider
{
    public static IServiceCollection InjectApplicationLayer(this IServiceCollection services)
    {
        services.InjectManagers();
        services.InjectServices();
        services.InjectHandlers();

        return services;
    }

    private static IServiceCollection InjectManagers(this IServiceCollection services)
    {
        services.AddTransient<IAuthManager, AuthManager>();
        services.AddTransient<IUserManager, UserManager>();
        services.AddTransient<IPatternTaskManager, PatternTaskManager>();
        services.AddTransient<IPatternPlanManager, PatternPlanManager>();
        services.AddTransient<IPatternPlanTaskManager, PatternPlanTaskManager>();
        services.AddTransient<IMentorInternManager, MentorInternManager>();
        services.AddTransient<IInternshipTaskManager, InternshipTaskManager>();
        services.AddTransient<IAssembledPatternTaskManager, AssembledPatternTaskManager>();
        services.AddTransient<IAssembledPatternPlanManager, AssembledPatternPlanManager>();

        return services;
    }

    private static IServiceCollection InjectServices(this IServiceCollection services)
    {
        services.AddScoped<UserService>();
        services.AddTransient<IAuthService, AuthService>();
        services.AddTransient<IPatternTaskService, PatternTaskService>();
        services.AddTransient<IPatternPlanService, PatternPlanService>();
        services.AddTransient<IPatternPlanTaskService, PatternPlanTaskService>();
        services.AddTransient<IMentorInternService, MentorInternService>();
        services.AddTransient<IInternshipTaskService, InternshipTaskService>();
        services.AddTransient<IAssembledPatternPlanService, AssembledPatternPlanService>();
        services.AddTransient<IAssembledPatternTaskService, AssembledPatternTaskService>();

        return services;
    }

    private static IServiceCollection InjectHandlers(this IServiceCollection services)
    {
        services.AddTransient<IErrorHandler, ErrorHandler>();

        return services;
    }
}
