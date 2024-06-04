using InternsAdaptationService.Application.Interfaces.IManagers.Auth;
using InternsAdaptationService.Application.Interfaces.IServices.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;

namespace InternsAdaptationService.Application.Managers.Auth;

public class AuthManager : IAuthManager
{
    private readonly IAuthService _authService;
    private readonly IUserMapper _userMapper;
    private readonly IRoleEnumMapper _roleEnumMapper;

    public AuthManager(IAuthService authService, IUserMapper userMapper, IRoleEnumMapper roleEnumMapper)
    {
        _authService = authService;
        _userMapper = userMapper;
        _roleEnumMapper = roleEnumMapper;
    }

    public async Task<IUserResponseModel> RegisterWithEmailAndPasswordAsync(IRegistrationRequestModel request)
    {
        var roleExist = _roleEnumMapper.RoleExist(request.Role);
        if (!roleExist)
            throw new Exception("The specified role does not exist");

        var user = _userMapper.ToNewEntity(request);

        var createdUser = await _authService.RegisterWithEmailAndPasswordAsync(user, request.Password);

        var response = _userMapper.ToResponse(createdUser);

        return response;
    }

    public async Task<IUserResponseModel> SignInWithEmailAndPasswordAsync(ISignInRequestModel request)
    {
        var user = await _authService.SigninWithEmailAndPasswordAsync(request.Email, request.Password);

        var response = _userMapper.ToResponse(user);

        return response;
    }

    public async Task SignOutAsync()
    {
        await _authService.SignOutAsync();
    }

    public async Task ChangePasswordAsync(Guid id, string oldPassword, string newPassword)
    {
        await _authService.ChangePasswordAsync(id, oldPassword, newPassword);
    }
}

