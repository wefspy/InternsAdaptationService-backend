using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers;

namespace InternsAdaptationService.Infrastructure.Mappers;

public class RoleEnumMapper : IRoleEnumMapper
{
    public RoleEnum ConvertToRoleEnum(string role)
    {
        var success = Enum.TryParse(role, out RoleEnum roleEnum);

        if (!success)
            throw new Exception("Invalid user role");

        return roleEnum;
    }
}
