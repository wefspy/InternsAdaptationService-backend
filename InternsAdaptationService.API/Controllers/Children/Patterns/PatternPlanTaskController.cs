using InternsAdaptationService.API.Controllers.Children.Abstracts;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Patterns;

[Route("api/pattern/planTask")]
[ApiController]
public class PatternPlanTaskController : BaseController<PatternPlanTaskRequestModel, PatternPlanTaskResponseModel, IPatternPlanTaskManager>
{
    private readonly IPatternPlanTaskManager _patternPlanTaskManager;

    public PatternPlanTaskController(IPatternPlanTaskManager patternPlanTaskManager) :
        base(patternPlanTaskManager)
    {
        _patternPlanTaskManager = patternPlanTaskManager;
    }

    [HttpPost("range")]
    public async Task<IActionResult> CreateRange(PatternPlanTaskRequestModel[] requests)
    {
        try
        {
            await _patternPlanTaskManager.CreateRangeAsync(requests);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("plan/{id:Guid}")]
    public async Task<ActionResult<IEnumerable<PatternPlanTaskResponseModel>>> GetByPlanId(Guid id)
    {
        try
        {
            var result = await _patternPlanTaskManager.GetByPlanIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
