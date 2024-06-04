using InternsAdaptationService.Application.Interfaces.IManagers.User;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.User;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.User;

[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserManager _userManager;

    public UserController(IUserManager userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserResponseModel>>> GetAll()
    {
        try
        {
            var result = await _userManager.GetAllAsync();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<UserResponseModel>> GetById(Guid id)
    {
        try
        {
            var result = await _userManager.GetByIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{role}")]
    public async Task<ActionResult<IEnumerable<UserResponseModel>>> GetInRoleAsync(string role)
    {
        try
        {
            var result = await _userManager.GetInRoleAsync(role);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id, UserRequestModel request)
    {
        try
        {
            await _userManager.UpdateAsync(id, request);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _userManager.DeleteAsync(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
