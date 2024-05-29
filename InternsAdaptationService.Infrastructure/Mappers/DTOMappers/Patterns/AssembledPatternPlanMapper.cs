using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;

public class AssembledPatternPlanMapper : IAssembledPatternPlanMapper
{
    public AssembledPatternPlanResponseModel ToResponse(PatternPlanResponseModel plan, IEnumerable<AssembledPatternTaskResponseModel> tasks)
    {
        return new AssembledPatternPlanResponseModel(plan.Id, plan.MentorId, plan.Title, tasks);
    }

    public PatternPlanRequestModel ToPatternPlanRequestModel(AssembledPatternPlanRequestModel request)
    {
        return new PatternPlanRequestModel(request.MentorId, request.Title);
    }
}
