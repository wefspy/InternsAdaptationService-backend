using InternsAdaptationService.API.Controllers.Children.Abstracts;
using InternsAdaptationService.Application.Interfaces.IManagers.Internships;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Internships;

[Route("api/internship/task")]
[ApiController]
public class InternshipTaskController : 
    BaseController<InternshipTaskRequestModel, IInternshipTaskRequestModel, InternshipTaskResponseModel, IInternshipTaskResponseModel, IInternshipTaskManager>
{
    private readonly IInternshipTaskManager _internshipTaskManager;

    public InternshipTaskController(IInternshipTaskManager internshipTaskManager) : base(internshipTaskManager)
    {
        _internshipTaskManager = internshipTaskManager;
    }

    [HttpGet("intern/{id:Guid}")]
    public async Task<ActionResult<IEnumerable<InternshipTaskResponseModel>>> GetByInternId(Guid id)
    {
        try
        {
            var result = await _internshipTaskManager.GetByInternIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }

    [HttpPost("range")]
    public async Task<ActionResult<IEnumerable<InternshipTaskResponseModel>>> CreateRange(IEnumerable<InternshipTaskRequestModel> requests)
    {
        try
        {
            await _internshipTaskManager.CreateRangeAsync(requests);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}
