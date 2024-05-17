﻿using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IPatternPlanMapper : IBaseDTOMapper<PatternPlanEntity, PatternPlanRequestModel, PatternPlanResponseModel>
{
}