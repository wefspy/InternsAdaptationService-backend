using InternsAdaptationService.Infrastructure.Interfaces.IMappers;
using InternsAdaptationService.Infrastructure.Mappers.EnumMappers;
using InternsAdaptationService.Infrastructure.Mappers.ModelMappers;
using Microsoft.Extensions.DependencyInjection;

namespace InternsAdaptationService.Infrastructure.DependencyInjection;

public static class MappersProvider
{
    public static IServiceCollection InjectMappers(this IServiceCollection services)
    {
        services.AddTransient<IRoleEnumMapper, RoleEnumMapper>();
        services.AddTransient<IUserMapper, UserMapper>();

        return services;
    }
}
