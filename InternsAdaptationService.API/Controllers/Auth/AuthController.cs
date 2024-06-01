using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Auth;
using Microsoft.AspNetCore.Mvc;


namespace InternsAdaptationService.API.Controllers.Auth;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthManager _authManager;

    public AuthController(IAuthManager authManager)
    {
        _authManager = authManager;
    }

    [HttpPost("register")]
    public async Task<ActionResult<UserResponseModel>> Register(RegistrationRequestModel request)
    {
        try
        {
            var response = await _authManager.RegisterWithEmailAndPasswordAsync(request);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("signin")]
    public async Task<ActionResult<UserResponseModel>> SignIn(SignInRequestModel request)
    {
        try
        {
            var response = await _authManager.SignInWithEmailAndPasswordAsync(request);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("signout")]
    public new async Task SignOut()
    {
        await _authManager.SignOutAsync();
    }

    [HttpPost("{id:Guid}/changePassword")]
    public async Task<IActionResult> ChangePassword(Guid id, string oldPassword, string newPassword)
    {
        try
        {
            await _authManager.ChangePasswordAsync(id, oldPassword, newPassword);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("seed/admin")]
    public async Task<IActionResult> SeedAdmin()
    {
        try
        {
            await _authManager.SeedAdmin();

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
