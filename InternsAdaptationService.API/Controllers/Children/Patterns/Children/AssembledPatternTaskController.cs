using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns.Children;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Patterns.Children;

[Route("api/pattern/task/assembled")]
[ApiController]
public class AssembledPatternTaskController : ControllerBase
{
    private readonly IAssembledPatternTaskManager _manager;

    public AssembledPatternTaskController(IAssembledPatternTaskManager manager)
    {
        _manager = manager;
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<PatternPlanTaskResponseModel>>> Create(AssembledPatternTaskRequestModel request)
    {
        try
        {
            var result = await _manager.CreateAsync(request);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("range")]
    public ActionResult<IEnumerable<PatternPlanTaskResponseModel>> CreateRange(IEnumerable<AssembledPatternTaskRequestModel> requests)
    {
        try
        {
            var result = _manager.CreateRange(requests);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
