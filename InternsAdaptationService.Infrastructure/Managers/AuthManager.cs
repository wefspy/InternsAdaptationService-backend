using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices;
using InternsAdaptationService.Infrastructure.Mappers;

namespace InternsAdaptationService.Infrastructure.Managers;

public class AuthManager : IAuthManager
{
    private readonly IAuthService _authService;
    private readonly IRoleEnumMapper _roleEnumMapper;

    public AuthManager(IAuthService authService, IRoleEnumMapper roleEnumMapper) 
    { 
        _authService = authService; 
        _roleEnumMapper = roleEnumMapper;
    }

    public async Task<AuthDataResponseModel> RegisterWithEmailAndPasswordAsync(RegistrationRequestModel request)
    {
        var roleEnum = _roleEnumMapper.ConvertToRoleEnum(request.Role);

        var user = UserMapper.ToUserModel(request);

        await _authService.RegisterWithEmailAndPasswordAsync(user, request.Password, roleEnum.ToString());

        var response = UserMapper.ToAuthDataResponseModel(user, request.Role);
        return response;
    }

    public async Task<AuthDataResponseModel> SignInWithEmailAndPasswordAsync(SignInRequestModel request)
    {
        var (user, role) = await _authService.SigninWithEmailAndPasswordAsync(request.Email, request.Password);

        var response = UserMapper.ToAuthDataResponseModel(user, role);
        return response;
    }

    public async Task SignOutAsync()
    {
        await _authService.SignOutAsync();
    }
}
