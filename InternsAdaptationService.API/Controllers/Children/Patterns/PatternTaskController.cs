using InternsAdaptationService.API.Controllers.Children.Abstracts;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Managers.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Patterns;

[Route("api/pattern/task")]
[ApiController]
public class PatternTaskController : BaseController<PatternTaskRequestModel, PatternTaskResponseModel, IPatternTaskManager>
{
    private readonly IPatternTaskManager _patternTaskManager;

    public PatternTaskController(IPatternTaskManager patternTaskManager) :
        base(patternTaskManager)
    {
        _patternTaskManager = patternTaskManager;
    }

    [HttpGet("mentor/{id:Guid}")]
    public async Task<ActionResult<IEnumerable<PatternTaskResponseModel>>> GetByMentorId(Guid id)
    {
        try
        {
            var result = await _patternTaskManager.GetByMentorIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("assembled")]
    public async Task<ActionResult<IEnumerable<PatternPlanTaskResponseModel>>> CreateAssembled(AssembledPatternTaskRequestModel request)
    {
        try
        {
            var result = await _patternTaskManager.CreateAssembledAsync(request);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("assembled/range")]
    public ActionResult<IEnumerable<PatternPlanTaskResponseModel>> CreateAssembledRange(IEnumerable<AssembledPatternTaskRequestModel> requests)
    {
        try
        {
            var result = _patternTaskManager.CreateRangeAssembled(requests);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
