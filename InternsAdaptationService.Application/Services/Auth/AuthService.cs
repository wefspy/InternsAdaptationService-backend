using InternsAdaptationService.Application.Interfaces.IHandlers;
using InternsAdaptationService.Application.Interfaces.IServices.Auth;
using InternsAdaptationService.Application.Services.User;
using InternsAdaptationService.Data.Entities.Auth;
using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Application.Services.Auth;

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

    public async Task<UserEntity> RegisterWithEmailAndPasswordAsync(UserEntity user, string password)
    {
        var createUser = await _userService.CreateAsync(user, password);
        if (!createUser.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(createUser.Errors));

        var roleExist = await _roleManager.RoleExistsAsync(user.Role);
        if (!roleExist)
            await _roleManager.CreateAsync(new RoleEntity() { Name = user.Role });

        var addRole = await _userService.AddToRoleAsync(user, user.Role);
        if (!addRole.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(addRole.Errors));

        return await SigninWithEmailAndPasswordAsync(user.Email!, password);
    }

    public async Task<UserEntity> SigninWithEmailAndPasswordAsync(string email, string password)
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

        return user;
    }

    public async Task SignOutAsync()
    {
        await _signinManager.SignOutAsync();
    }

    public async Task ChangePasswordAsync(Guid id, string oldPassword, string newPassword)
    {
        var user = await _userService.GetUserByIdAsync(id);

        var result = await _userService.ChangePasswordAsync(user, oldPassword, newPassword);
        if (!result.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(result.Errors));
    }
}
