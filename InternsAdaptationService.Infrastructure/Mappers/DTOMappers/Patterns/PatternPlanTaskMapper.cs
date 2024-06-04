using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;

public class PatternPlanTaskMapper : BaseDTOMapper<PatternPlanTaskEntity, IPatternPlanTaskRequestModel, IPatternPlanTaskResponseModel>,
    IPatternPlanTaskMapper
{
    protected override PatternPlanTaskEntity ToEntity(IPatternPlanTaskRequestModel request)
    {
        return new PatternPlanTaskEntity
        {
            PlanId = request.PlanId,
            TaskId = request.TaskId,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
        };
    }

    public override IPatternPlanTaskResponseModel ToResponse(PatternPlanTaskEntity entity)
    {
        return new PatternPlanTaskResponseModel(entity.Id, entity.PlanId, entity.TaskId, entity.StartDate, entity.EndDate);
    }
}
