using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;

public class PatternPlanMapper : IPatternPlanMapper
{
    public PatternPlanEntity ToNewEntity(PatternPlanRequestModel request)
    {
        var entity = ToEntity(request);
        entity.Id = Guid.NewGuid();

        return entity;
    }

    public PatternPlanEntity ToExistEntity(Guid id, PatternPlanRequestModel request)
    {
        var entity = ToEntity(request);
        entity.Id = id;

        return entity;
    }

    private PatternPlanEntity ToEntity(PatternPlanRequestModel request)
    {
        return new PatternPlanEntity
        {
            MentorId = request.MentorId,
            Title = request.Title,
        };
    }

    public PatternPlanResponseModel ToResponse(PatternPlanEntity entity)
    {
        return new PatternPlanResponseModel(entity.Id, entity.MentorId, entity.Title);
    }
}
