using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns.Children;

public class AssembledPatternPlanMapper : IAssembledPatternPlanMapper
{
    public IAssembledPatternPlanResponseModel ToResponse(PatternPlanEntity plan, IEnumerable<IAssembledPatternTaskResponseModel> tasks)
    {
        return new AssembledPatternPlanResponseModel(plan.Id, plan.MentorId, plan.Title, tasks);
    }

    public IPatternPlanRequestModel ToPatternPlanRequestModel(IAssembledPatternPlanRequestModel request)
    {
        return new PatternPlanRequestModel(request.MentorId, request.Title);
    }
}
