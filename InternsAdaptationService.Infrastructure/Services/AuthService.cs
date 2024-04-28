using InternsAdaptationService.Data.Models;
using InternsAdaptationService.Infrastructure.Interfaces.IHandlers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Infrastructure.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signinManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly IErrorHandler _errorHandler;

    public AuthService(UserManager<User> userManager, SignInManager<User> signinManager, RoleManager<Role> roleManager, IErrorHandler errorHandler)
    {
        _userManager = userManager;
        _signinManager = signinManager;
        _roleManager = roleManager;
        _errorHandler = errorHandler;
    }

    public async Task RegisterWithEmailAndPasswordAsync(User user, string password, string role)
    {
        var createUser = await _userManager.CreateAsync(user, password);
        if (!createUser.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(createUser.Errors));

        await _roleManager.CreateAsync(new Role() { Name = role });

        var addRole = await _userManager.AddToRoleAsync(user, role);
        if (!addRole.Succeeded)
            throw new Exception(_errorHandler.IdentityExceptionsToString(addRole.Errors));

        var signinUser = await _signinManager.PasswordSignInAsync(user, password, true, true);
        if (!signinUser.Succeeded)
            throw new Exception("User created but unable signin");
    }

    public async Task<(User, string)> SigninWithEmailAndPasswordAsync(string email, string password)
    {
        var signinUser = await _signinManager.PasswordSignInAsync(email, password, true, true);
        if (!signinUser.Succeeded)
            throw new Exception("Invalid login or password");

        var user = await _userManager.FindByNameAsync(email);
        
        var role = (await _userManager.GetRolesAsync(user!)).First();

        return (user!, role);
    }

    public async Task SignOutAsync()
    {
        await _signinManager.SignOutAsync();
    }
}
