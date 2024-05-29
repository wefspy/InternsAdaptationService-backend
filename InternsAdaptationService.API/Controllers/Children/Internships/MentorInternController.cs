using InternsAdaptationService.API.Controllers.Children.Abstracts;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Internships;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Internships;

[Route("api/internship/mentorIntern")]
[ApiController]
public class MentorInternController : BaseController<MentorInternRequestModel, MentorInternResponseModel, IMentorInternManager>
{
    private readonly IMentorInternManager _mentorInternManager;

    public MentorInternController(IMentorInternManager mentorInternManager) : base(mentorInternManager)
    {
        _mentorInternManager = mentorInternManager;
    }

    [HttpGet("mentor/{id:Guid}")]
    public async Task<ActionResult<IEnumerable<MentorInternResponseModel>>> GetByMentorId(Guid id)
    {
        try
        {
            var result = await _mentorInternManager.GetByMentorIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("mentor/{id:Guid}/users")]
    public async Task<ActionResult<IEnumerable<UserResponseModel>>> GetInternsByMentorId(Guid id)
    {
        try
        {
            var result = await _mentorInternManager.GetInternsByMentorId(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("intern/{id:Guid}")]
    public async Task<ActionResult<IEnumerable<MentorInternResponseModel>>> GetByInternId(Guid id)
    {
        try
        {
            var result = await _mentorInternManager.GetByInternIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("intern/{id:Guid}/users")]
    public async Task<ActionResult<IEnumerable<UserResponseModel>>> GetMentorsByInternId(Guid id)
    {
        try
        {
            var result = await _mentorInternManager.GetMentorsByInternId(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("mentor/{id:Guid}")]
    public async Task<IActionResult> DeleteByMentorId(Guid id)
    {
        try
        {
            await _mentorInternManager.DeleteByMentorId(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("intern/{id:Guid}")]
    public async Task<IActionResult> DeleteByInternId(Guid id)
    {
        try
        {
            await _mentorInternManager.DeleteByInternId(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
