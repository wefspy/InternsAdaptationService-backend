using InternsAdaptationService.Infrastructure.DTO.Objects.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;

public interface IAssembledPatternPlanRequestModel : IPatternPlanRequestModel, IBaseRequestModel
{
    public IEnumerable<AssembledPatternTaskObject> Tasks { get; }
}
