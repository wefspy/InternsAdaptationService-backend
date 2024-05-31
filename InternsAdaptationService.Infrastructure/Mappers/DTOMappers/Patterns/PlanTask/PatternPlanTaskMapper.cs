using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns.PlanTask;

public class PatternPlanTaskMapper : BaseDTOMapper<PatternPlanTaskEntity, PatternPlanTaskRequestModel, PatternPlanTaskResponseModel>,
    IPatternPlanTaskMapper
{
    protected override PatternPlanTaskEntity ToEntity(PatternPlanTaskRequestModel request)
    {
        return new PatternPlanTaskEntity
        {
            PlanId = request.PlanId,
            TaskId = request.TaskId,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
        };
    }

    public override PatternPlanTaskResponseModel ToResponse(PatternPlanTaskEntity entity)
    {
        return new PatternPlanTaskResponseModel(entity.Id, entity.PlanId, entity.TaskId, entity.StartDate, entity.EndDate);
    }
}
