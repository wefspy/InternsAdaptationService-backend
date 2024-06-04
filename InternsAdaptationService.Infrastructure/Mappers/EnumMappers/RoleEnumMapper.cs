using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;

namespace InternsAdaptationService.Infrastructure.Mappers.EnumMappers;

public class RoleEnumMapper : IRoleEnumMapper
{
    public RoleEnum ConvertToRoleEnum(string role)
    {
        var roleExist = RoleExist(role);

        if (!roleExist)
            throw new Exception("The specified role does not exist");

        return Enum.Parse<RoleEnum>(role);
    }

    public bool RoleExist(string role)
    {
        return Enum.IsDefined(typeof(RoleEnum), role);
    }
}
