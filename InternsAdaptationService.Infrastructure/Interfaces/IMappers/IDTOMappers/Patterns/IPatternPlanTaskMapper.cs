using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IPatternPlanTaskMapper : IBaseDTOMapper<PatternPlanTaskEntity, PatternPlanTaskRequestModel, PatternPlanTaskResponseModel>
{
}
