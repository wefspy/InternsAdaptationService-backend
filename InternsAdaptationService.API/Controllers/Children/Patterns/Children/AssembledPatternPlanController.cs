using InternsAdaptationService.Application.Interfaces.IManagers.Patterns.Children;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Children;
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
            return BadRequest(ex);
        }
    }

    [HttpPost("{id:Guid}")]
    public async Task<IActionResult> Load(Guid id, Guid internId, DateTime startDateInternship)
    {
        try
        {
            await _manager.LoadAsync(id, internId, startDateInternship);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
