using InternsAdaptationService.Data.Enums;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers;

public interface IRoleEnumMapper
{
    public RoleEnum ConvertToRoleEnum(string role);
}
