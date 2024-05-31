﻿using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns.Plan;

public class PatternPlanMapper : BaseDTOMapper<PatternPlanEntity, PatternPlanRequestModel, PatternPlanResponseModel>,
    IPatternPlanMapper
{
    protected override PatternPlanEntity ToEntity(PatternPlanRequestModel request)
    {
        return new PatternPlanEntity
        {
            MentorId = request.MentorId,
            Title = request.Title,
        };
    }

    public override PatternPlanResponseModel ToResponse(PatternPlanEntity entity)
    {
        return new PatternPlanResponseModel(entity.Id, entity.MentorId, entity.Title);
    }
}