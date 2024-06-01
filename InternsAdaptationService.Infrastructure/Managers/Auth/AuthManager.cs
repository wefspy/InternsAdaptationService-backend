using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IEnumMappers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Auth;

namespace InternsAdaptationService.Infrastructure.Managers.Auth;

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

    public async Task SeedAdmin()
    {
        var admin = new RegistrationRequestModel("admin@example.com", "Pas123456", "admin", "admin", "admin", "Admin");

        var roleEnum = _roleEnumMapper.ConvertToRoleEnum(admin.Role);

        var user = _userMapper.ToNewEntity(admin);

        await _authService.RegisterWithEmailAndPasswordAsync(user, admin.Password, roleEnum.ToString());
    }

    public async Task<UserResponseModel> RegisterWithEmailAndPasswordAsync(RegistrationRequestModel request)
    {
        var roleEnum = _roleEnumMapper.ConvertToRoleEnum(request.Role);

        var user = _userMapper.ToNewEntity(request);

        var (createdUser, createdRole) = await _authService.RegisterWithEmailAndPasswordAsync(user, request.Password, roleEnum.ToString());

        var response = _userMapper.ToResponse(createdUser, createdRole);
        return response;
    }

    public async Task<UserResponseModel> SignInWithEmailAndPasswordAsync(SignInRequestModel request)
    {
        var (user, role) = await _authService.SigninWithEmailAndPasswordAsync(request.Email, request.Password);

        var response = _userMapper.ToResponse(user, role);
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
