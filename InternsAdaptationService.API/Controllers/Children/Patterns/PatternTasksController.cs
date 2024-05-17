using InternsAdaptationService.API.Controllers.Children.Abstracts;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Managers.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Patterns;

[Route("api/pattern/tasks")]
[ApiController]
public class PatternTasksController : BaseController<PatternTaskRequestModel, PatternTaskResponseModel, IPatternTaskManager>
{
    private readonly IPatternTaskManager _patternTaskManager;

    public PatternTasksController(IPatternTaskManager patternTaskManager) :
        base(patternTaskManager)
    {
        _patternTaskManager = patternTaskManager;
    }

    [HttpGet("mentorId/{id:Guid}")]
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
}
