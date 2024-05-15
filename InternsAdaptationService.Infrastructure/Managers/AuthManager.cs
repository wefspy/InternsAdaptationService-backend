using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices;

namespace InternsAdaptationService.Infrastructure.Managers;

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

    public async Task<AuthDataResponseModel> RegisterWithEmailAndPasswordAsync(RegistrationRequestModel request)
    {
        var roleEnum = _roleEnumMapper.ConvertToRoleEnum(request.Role);

        var user = _userMapper.ToEntity(request);

        var (createdUser, createdRole) = await _authService.RegisterWithEmailAndPasswordAsync(user, request.Password, roleEnum.ToString());

        var response = _userMapper.ToResponse(createdUser, createdRole);
        return response;
    }

    public async Task<AuthDataResponseModel> SignInWithEmailAndPasswordAsync(SignInRequestModel request)
    {
        var (user, role) = await _authService.SigninWithEmailAndPasswordAsync(request.Email, request.Password);

        var response = _userMapper.ToResponse(user, role);
        return response;
    }

    public async Task SignOutAsync()
    {
        await _authService.SignOutAsync();
    }
}
