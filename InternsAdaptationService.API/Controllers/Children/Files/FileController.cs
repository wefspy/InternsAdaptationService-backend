using InternsAdaptationService.Application.Interfaces.IManagers.Files;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Files;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Files;


[Route("api/file")]
[ApiController]
public class FileController : ControllerBase
{
    private readonly IFileManager _fileManager;

    public FileController(IFileManager fileManager)
    {
        _fileManager = fileManager;
    }

    [HttpPost]
    public virtual async Task<ActionResult<FileResponseModel>> Create(Guid taskId, IFormFile file)
    {
        try
        {
            var result = await _fileManager.CreateAsync(taskId, file);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("range")]
    public virtual async Task<ActionResult<FileResponseModel>> CreateRange(Guid taskId, IEnumerable<IFormFile> files)
    {
        try
        {
            var result = await _fileManager.CreateRangeAsync(taskId, files);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpGet]
    public virtual async Task<ActionResult<IEnumerable<FileResponseModel>>> GetAll()
    {
        try
        {
            var result = await _fileManager.GetAllAsync();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id:Guid}")]
    public virtual async Task<ActionResult<FileResponseModel>> GetById(Guid id)
    {
        try
        {
            var result = await _fileManager.GetByIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("task/{id:Guid}")]
    public virtual async Task<ActionResult<FileResponseModel>> GetByTaskId(Guid id)
    {
        try
        {
            var result = await _fileManager.GetByTaskId(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id:Guid}")]
    public virtual async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _fileManager.DeleteAsync(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
