using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace InternsAdaptationService.Infrastructure.DependencyInjection;

public static class AuthOptionsProvider
{
    public static IServiceCollection InjectAuthOptions(this IServiceCollection services)
    {
        services.AddAuthentication().AddBearerToken();
        services.AddAuthorization();

        services.AddIdentity<User, Role>(options =>
        {
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireDigit = true;
            options.User.RequireUniqueEmail = true;
            options.SignIn.RequireConfirmedAccount = false;
        })
        .AddEntityFrameworkStores<InternsAdaptationServiceDbContext>()
        .AddDefaultTokenProviders();

        return services;
    }
}
