using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IAssembledPatternPlanMapper
{
    public AssembledPatternPlanResponseModel ToResponse(PatternPlanResponseModel plan, IEnumerable<AssembledPatternTaskResponseModel> tasks);

    public PatternPlanRequestModel ToPatternPlanRequestModel(AssembledPatternPlanRequestModel request);
}
