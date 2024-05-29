using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IAssembledPatternTaskMapper
{
    public AssembledPatternTaskResponseModel ToResponse(PatternPlanTaskResponseModel planTask, PatternTaskResponseModel task);

    public PatternTaskRequestModel ToPatternTaskRequestModel(AssembledPatternTaskRequestModel request);

    public PatternPlanTaskRequestModel ToPatternPlanTaskRequestModel(Guid taskId, AssembledPatternTaskRequestModel request);
}
