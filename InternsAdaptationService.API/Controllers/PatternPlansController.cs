using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers;

[Route("api/pattern/plans")]
[ApiController]
public class PatternPlansController : ControllerBase
{
    private readonly IPatternPlanManager _patternPlanManager;

    public PatternPlansController(IPatternPlanManager patternPlanManager)
    {
        _patternPlanManager = patternPlanManager;
    }

    [HttpPost]
    public async Task<ActionResult<PatternPlanResponseModel>> Create(PatternPlanRequestModel request)
    {
        try
        {
            var result = await _patternPlanManager.CreateAsync(request);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id, PatternPlanRequestModel request)
    {
        try
        {
            await _patternPlanManager.UpdateAsync(id, request);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PatternPlanResponseModel>>> GetAll()
    {
        try
        {
            var result = await _patternPlanManager.GetAllAsync();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<PatternPlanResponseModel>> GetById(Guid id)
    {
        try
        {
            var result = await _patternPlanManager.GetByIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("mentorId/{id:Guid}")]
    public async Task<ActionResult<IEnumerable<PatternPlanResponseModel>>> GetByMentorId(Guid id)
    {
        try
        {
            var result = await _patternPlanManager.GetByMentorIdAsync(id);

            return Ok(result);
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
            await _patternPlanManager.DeleteAsync(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
