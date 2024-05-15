using InternsAdaptationService.Infrastructure.DTO.RequestModels.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.PatternTask;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers;

[Route("api/patternTasks")]
[ApiController]
public class PatternTasksController : ControllerBase
{
    private readonly IPatternTaskManager _patternTaskManager;

    public PatternTasksController(IPatternTaskManager patternTaskManager)
    {
        _patternTaskManager = patternTaskManager;
    }

    [HttpPost]
    public async Task<ActionResult<PatternTaskResponseModel>> Create(PatternTaskRequestModel request)
    {
        try
        {
            var result = await _patternTaskManager.CreateAsync(request);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id, PatternTaskRequestModel request)
    {
        try
        {
            await _patternTaskManager.UpdateAsync(id, request);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PatternTaskResponseModel>>> GetAll()
    {
        try
        {
            var result = await _patternTaskManager.GetAllAsync();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<PatternTaskResponseModel>> GetById(Guid id)
    {
        try
        {
            var result = await _patternTaskManager.GetByIdAsync(id);

            return Ok(result);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("mentorId/{id:Guid}")]
    public async Task<ActionResult<IEnumerable<PatternTaskResponseModel>>> GetByMentorId(Guid id)
    {
        try
        {
            var result = await _patternTaskManager.GetByMentorIdAsync(id);

            return Ok(result);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _patternTaskManager.DeleteAsync(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
