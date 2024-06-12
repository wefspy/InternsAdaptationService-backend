using InternsAdaptationService.Application.Interfaces.IHandlers;
using InternsAdaptationService.Application.Interfaces.IManagers.User;
using InternsAdaptationService.Application.Services.User;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;

namespace InternsAdaptationService.Application.Managers.User;

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

    public async Task<IUserResponseModel> GetByIdAsync(Guid id)
    {
        var user = await _userService.GetUserByIdAsync(id);

        return _userMapper.ToResponse(user);
    }

    public async Task<IEnumerable<IUserResponseModel>> GetAllAsync()
    {
        var users = await _userService.GetAllUsersAsync();

        return users.Select(user => _userMapper.ToResponse(user));
    }

    public async Task<IEnumerable<IUserResponseModel>> GetInRoleAsync(string role)
    {
        _roleEnumMapper.ConvertToRoleEnum(role);

        var entities = await _userService.GetUsersInRoleAsync(role);

        return entities
            .Select(entity => _userMapper.ToResponse(entity));
    }

    public async Task UpdateAsync(Guid id, IUserRequestModel request)
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

    public async Task UpdateUrlAsync(Guid id, string url)
    {
        var user = await _userService.GetUserByIdAsync(id);

        user.Url = url;

        var result = await _userService.UpdateAsync(user);
        if (!result.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(result.Errors));
    }

    public async Task DeleteAsync(Guid id)
    {
        var user = await _userService.GetUserByIdAsync(id);

        await _userService.DeleteAsync(user);
    }
}
