using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;
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
    public async Task<ActionResult<AuthDataResponseModel>> Register(RegistrationRequestModel request)
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
    public async Task<ActionResult<AuthDataResponseModel>> SignIn(SignInRequestModel request)
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
}
