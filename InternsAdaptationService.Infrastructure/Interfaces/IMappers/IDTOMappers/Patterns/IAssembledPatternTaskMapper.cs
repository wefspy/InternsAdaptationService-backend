using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IAssembledPatternTaskMapper
{
    public AssembledPatternTaskResponseModel ToResponse(PatternPlanTaskResponseModel planTask, PatternTaskResponseModel task);

    public AssembledPatternTaskRequestModel ToRequest(BodyAssembledPatternTaskRequestModel body, PatternPlanResponseModel plan);

    public PatternTaskRequestModel ToPatternTaskRequestModel(AssembledPatternTaskRequestModel request);

    public PatternPlanTaskRequestModel ToPatternPlanTaskRequestModel(Guid taskId, AssembledPatternTaskRequestModel request);

}
