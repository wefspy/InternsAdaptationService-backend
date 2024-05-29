﻿using InternsAdaptationService.API.Controllers.Children.Abstracts;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Patterns;

[Route("api/pattern/plan")]
[ApiController]
public class PatternPlanController : BaseController<PatternPlanRequestModel, PatternPlanResponseModel, IPatternPlanManager>
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

    [HttpPost("assembled")]
    public async Task<ActionResult<IEnumerable<PatternPlanResponseModel>>> CreateAssembled(AssembledPatternPlanRequestModel request)
    {
        try
        {
            var result = await _patternPlanManager.CreateAssembledAsync(request);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
