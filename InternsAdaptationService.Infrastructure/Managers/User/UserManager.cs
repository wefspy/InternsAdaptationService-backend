using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.User;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IHandlers;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;
using InternsAdaptationService.Infrastructure.Services.User;
using System.Xml.Linq;

namespace InternsAdaptationService.Infrastructure.Managers.User;

public class UserManager : IUserManager
{
    private readonly UserService _userService;
    private readonly IUserMapper _userMapper;
    private readonly IRoleEnumMapper _roleEnumMapper;
    private readonly IErrorHandler _errorHandler;

    public UserManager(UserService userService, IUserMapper userMapper, IRoleEnumMapper roleEnumMapper, IErrorHandler errorHandler)
    {
        _userService = userService;
        _userMapper = userMapper;
        _roleEnumMapper = roleEnumMapper;
        _errorHandler = errorHandler;
    }

    public async Task<UserResponseModel> GetByIdAsync(Guid id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        var roles = await _userService.GetRolesAsync(user);

        return _userMapper.ToResponse(user, roles.First());
    }

    public async Task<IEnumerable<UserResponseModel>> GetAllAsync()
    {
        var admins = await GetInRoleAsync(RoleEnum.Admin.ToString());
        var mentors = await GetInRoleAsync(RoleEnum.Mentor.ToString());
        var interns = await GetInRoleAsync(RoleEnum.Intern.ToString());

        return admins.Concat(mentors).Concat(interns);
    }

    public async Task<IEnumerable<UserResponseModel>> GetInRoleAsync(string role)
    {
        _roleEnumMapper.ConvertToRoleEnum(role);

        var entities = await _userService.GetUsersInRoleAsync(role);

        return entities
            .Select(entity => _userMapper.ToResponse(entity, role));
    }

    public async Task UpdateAsync(Guid id, UserRequestModel request)
    {
        var user = await _userService.GetUserByIdAsync(id);

        user.Name = request.Name;
        user.Surname = request.Surname;
        user.MiddleName = request.MiddleName;
        user.DesciptionProfile = request.DesciptionProfile;
        user.Telegram = request.Telegram;
        user.VK = request.VK;
       
        var result = await _userService.UpdateAsync(user);
        if (!result.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(result.Errors));
    }
}
