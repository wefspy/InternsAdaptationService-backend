using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IObjects.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns.Children;

public interface IAssembledPatternTaskMapper
{
    public IAssembledPatternTaskResponseModel ToResponse(PatternPlanTaskEntity planTask, PatternTaskEntity task);

    public IAssembledPatternTaskRequestModel ToRequest(IAssembledPatternTaskObject body, PatternPlanEntity plan);
}
