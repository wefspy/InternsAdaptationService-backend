using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns.Children;

public interface IAssembledPatternPlanMapper
{
    public IAssembledPatternPlanResponseModel ToResponse(PatternPlanEntity plan, IEnumerable<IAssembledPatternTaskResponseModel> tasks);

    public IPatternPlanRequestModel ToPatternPlanRequestModel(IAssembledPatternPlanRequestModel request);
}
