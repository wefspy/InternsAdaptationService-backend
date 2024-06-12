using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Auth;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Files;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns.Children;
using InternsAdaptationService.Infrastructure.Mappers.EnumMappers;

namespace InternsAdaptationService.API.Extensions;

public static class InfrastructureLayerProvider
{
    public static IServiceCollection InjectInfrastructureLayer(this IServiceCollection services)
    {
        services.InjectMappers();

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
        services.AddTransient<IInternshipTaskMapper, InternshipTaskMapper>();
        services.AddTransient<IAssembledPatternTaskMapper, AssembledPatternTaskMapper>();
        services.AddTransient<IAssembledPatternPlanMapper, AssembledPatternPlanMapper>();
        services.AddTransient<IFileMapper, FileMapper>();

        return services;
    }
}
