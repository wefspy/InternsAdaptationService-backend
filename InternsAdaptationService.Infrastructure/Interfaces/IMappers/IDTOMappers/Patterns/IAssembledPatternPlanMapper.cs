using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IAssembledPatternPlanMapper
{
    public AssembledPatternPlanResponseModel ToResponse(PatternPlanResponseModel plan, IEnumerable<AssembledPatternTaskResponseModel> tasks);

    public PatternPlanRequestModel ToPatternPlanRequestModel(AssembledPatternPlanRequestModel request);
}
