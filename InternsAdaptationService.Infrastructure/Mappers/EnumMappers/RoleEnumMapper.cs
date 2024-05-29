using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;

namespace InternsAdaptationService.Infrastructure.Mappers.EnumMappers;

public class RoleEnumMapper : IRoleEnumMapper
{
    public RoleEnum ConvertToRoleEnum(string role)
    {
        var success = Enum.TryParse(role, out RoleEnum roleEnum);

        if (!success)
            throw new Exception("The specified role does not exist");

        return roleEnum;
    }
}
