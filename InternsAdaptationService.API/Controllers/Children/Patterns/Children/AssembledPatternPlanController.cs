using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns.Children;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Patterns.Children;

[Route("api/pattern/plan/assembled")]
[ApiController]
public class AssembledPatternPlanController : ControllerBase
{
    private readonly IAssembledPatternPlanManager _manager;

    public AssembledPatternPlanController(IAssembledPatternPlanManager manager)
    {
        _manager = manager;
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<AssembledPatternPlanResponseModel>>> Create(AssembledPatternPlanRequestModel request)
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

    [HttpPost("{id:Guid}")]
    public async Task<IActionResult> Load(Guid id, Guid internId)
    {
        try
        {
            await _manager.LoadAsync(id, internId);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
