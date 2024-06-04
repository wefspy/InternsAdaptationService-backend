using InternsAdaptationService.Application.Interfaces.IManagers.Patterns.Children;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
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
    public async Task<ActionResult<IEnumerable<PatternPlanTaskResponseModel>>> CreateRange(IEnumerable<AssembledPatternTaskRequestModel> requests)
    {
        try
        {
            var result = await _manager.CreateRangeAsync(requests);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
