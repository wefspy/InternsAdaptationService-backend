﻿using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Auth;
using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.API.Extensions;

public static class AuthOptionsProvider
{
    public static IServiceCollection InjectAuthOptions(this IServiceCollection services)
    {
        services.AddAuthentication().AddBearerToken();
        services.AddAuthorization();

        services.AddIdentity<UserEntity, RoleEntity>(options =>
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
