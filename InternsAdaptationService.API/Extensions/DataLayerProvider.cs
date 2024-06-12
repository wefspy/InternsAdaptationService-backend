using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Interfaces.IRepositories.Files;
using InternsAdaptationService.Data.Interfaces.IRepositories.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.User;
using InternsAdaptationService.Data.Repositories.Files;
using InternsAdaptationService.Data.Repositories.Internships;
using InternsAdaptationService.Data.Repositories.Patterns;
using InternsAdaptationService.Data.Repositories.User;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.API.Extensions;

public static class DataLayerProvider
{
    public static IServiceCollection InjectDataLayer(this IServiceCollection services, string connectionString)
    {
        services.InjectDbContext(connectionString);
        services.InjectRepositories();

        return services;
    }

    private static IServiceCollection InjectDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<InternsAdaptationServiceDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        return services;
    }

    private static IServiceCollection InjectRepositories(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IPatternTaskRepository, PatternTaskRepository>();
        services.AddTransient<IPatternPlanRepository, PatternPlanRepository>();
        services.AddTransient<IPatternPlanTaskRepository, PatternPlanTaskRepository>();
        services.AddTransient<IMentorInternRepository, MentorInternRepository>();
        services.AddTransient<IInternshipTaskRepository, InternshipTaskRepository>();
        services.AddTransient<IFileRepository, FileRepository>();

        return services;
    }
}
