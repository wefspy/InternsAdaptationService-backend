using InternsAdaptationService.Application.Interfaces.IManagers.User;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.User;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.User;

[Route("api/user")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserManager _userManager;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public UserController(IUserManager userManager, IWebHostEnvironment webHostEnvironment)
    {
        _userManager = userManager;
        _webHostEnvironment = webHostEnvironment;
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

            var uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "uploads", id.ToString());
            Directory.Delete(uploadsFolder, true);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("{id:Guid}/upload")]
    public async Task<IActionResult> Upload(Guid id, IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            return BadRequest("File not selected.");
        }

        var uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "uploads", id.ToString());
        Directory.CreateDirectory(uploadsFolder);

        var extension = file.ContentType.Split('/').Last();
        var filename = "avatar" + "." + extension;
        var filePath = Path.Combine(uploadsFolder, filename);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }
        
        var fileUrl = $"{Request.Scheme}://{Request.Host}/uploads/{id}/{filename}";

        await _userManager.UpdateUrlAsync(id, fileUrl);

        return Ok(new { Url = fileUrl });
    }
}
