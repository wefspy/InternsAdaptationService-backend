﻿using InternsAdaptationService.API.Controllers.Children.Abstracts;
using InternsAdaptationService.Application.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Patterns;

[Route("api/pattern/task")]
[ApiController]
public class PatternTaskController : 
    BaseController<PatternTaskRequestModel, IPatternTaskRequestModel, PatternTaskResponseModel, IPatternTaskResponseModel, IPatternTaskManager>
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
}
