using InternsAdaptationService.Data.Enums;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;

public interface IRoleEnumMapper
{
    public RoleEnum ConvertToRoleEnum(string role);

    public bool RoleExist(string role);
}
