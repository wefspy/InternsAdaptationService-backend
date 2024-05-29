using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IHandlers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Auth;
using InternsAdaptationService.Infrastructure.Services.User;
using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Infrastructure.Services.Auth;

public class AuthService : IAuthService
{
    private readonly UserService _userService;
    private readonly SignInManager<UserEntity> _signinManager;
    private readonly RoleManager<RoleEntity> _roleManager;
    private readonly IErrorHandler _errorHandler;

    public AuthService(UserService userManager, SignInManager<UserEntity> signinManager, RoleManager<RoleEntity> roleManager, IErrorHandler errorHandler)
    {
        _userService = userManager;
        _signinManager = signinManager;
        _roleManager = roleManager;
        _errorHandler = errorHandler;
    }

    public async Task<(UserEntity userEntity, string userRole)> RegisterWithEmailAndPasswordAsync(UserEntity user, string password, string role)
    {
        var createUser = await _userService.CreateAsync(user, password);
        if (!createUser.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(createUser.Errors));

        var roleExist = await _roleManager.RoleExistsAsync(role);
        if (!roleExist)
            await _roleManager.CreateAsync(new RoleEntity() { Name = role });

        var addRole = await _userService.AddToRoleAsync(user, role);
        if (!addRole.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(addRole.Errors));

        return await SigninWithEmailAndPasswordAsync(user.Email!, password);
    }

    public async Task<(UserEntity userEntity, string userRole)> SigninWithEmailAndPasswordAsync(string email, string password)
    {
        var user = await _userService.FindByEmailAsync(email);
        if (user == null)
            throw new Exception("UserNotCreated");

        var role = (await _userService.GetRolesAsync(user!)).FirstOrDefault()!;
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
