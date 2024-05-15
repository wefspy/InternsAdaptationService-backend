using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Interfaces.IRepositories;
using InternsAdaptationService.Data.Repositories;
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
        services.AddTransient<IPatternTaskRepository, PatternTaskRepository>();

        return services;
    }
}
