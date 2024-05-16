using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IHandlers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Auth;
using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Infrastructure.Services.Auth;

public class AuthService : IAuthService
{
    private readonly UserManager<UserEntity> _userManager;
    private readonly SignInManager<UserEntity> _signinManager;
    private readonly RoleManager<RoleEntity> _roleManager;
    private readonly IErrorHandler _errorHandler;

    public AuthService(UserManager<UserEntity> userManager, SignInManager<UserEntity> signinManager, RoleManager<RoleEntity> roleManager, IErrorHandler errorHandler)
    {
        _userManager = userManager;
        _signinManager = signinManager;
        _roleManager = roleManager;
        _errorHandler = errorHandler;
    }

    public async Task<(UserEntity userEntity, string userRole)> RegisterWithEmailAndPasswordAsync(UserEntity user, string password, string role)
    {
        var createUser = await _userManager.CreateAsync(user, password);
        if (!createUser.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(createUser.Errors));

        var createRole = await _roleManager.CreateAsync(new RoleEntity() { Name = role });
        if (!createRole.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(createRole.Errors));

        var addRole = await _userManager.AddToRoleAsync(user, role);
        if (!addRole.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(addRole.Errors));

        return await SigninWithEmailAndPasswordAsync(user.Email!, password);
    }

    public async Task<(UserEntity userEntity, string userRole)> SigninWithEmailAndPasswordAsync(string email, string password)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            throw new Exception("UserNotCreated");

        var role = (await _userManager.GetRolesAsync(user!)).First();
        if (role == null)
            throw new Exception("UserIsNotAssignedRole");

        var signinUser = await _signinManager.PasswordSignInAsync(email, password, true, true);
        if (!signinUser.Succeeded)
            throw new Exception("InvalidLoginOrPassword");

        return (user, role);
    }

    public async Task SignOutAsync()
    {
        await _signinManager.SignOutAsync();
    }
}
