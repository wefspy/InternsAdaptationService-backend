﻿using InternsAdaptationService.API.Controllers.Children.Abstracts;
using InternsAdaptationService.Application.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Patterns;

[Route("api/pattern/plan")]
[ApiController]
public class PatternPlanController :
    BaseController<PatternPlanRequestModel, IPatternPlanRequestModel, PatternPlanResponseModel, IPatternPlanResponseModel, IPatternPlanManager>
{
    private readonly IPatternPlanManager _patternPlanManager;

    public PatternPlanController(IPatternPlanManager patternPlanManager) :
        base(patternPlanManager)
    {
        _patternPlanManager = patternPlanManager;
    }

    [HttpGet("mentor/{id:Guid}")]
    public async Task<ActionResult<IEnumerable<PatternPlanResponseModel>>> GetByMentorId(Guid id)
    {
        try
        {
            var result = await _patternPlanManager.GetByMentorIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{role}")]
    public async Task<ActionResult<IEnumerable<PatternPlanResponseModel>>> GetFromRole(string role)
    {
        try
        {
            var result = await _patternPlanManager.GetFromRoleAsync(role);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
