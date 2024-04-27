using InternsAdaptationService.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InternsAdaptationService.Infrastructure.DependencyInjection;

public static class DbContextProvider
{
    public static void AddDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<InternsAdaptationServiceDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
    }
}
