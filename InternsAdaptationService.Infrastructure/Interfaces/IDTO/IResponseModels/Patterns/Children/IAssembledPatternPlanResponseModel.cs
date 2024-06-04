using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

public interface IAssembledPatternPlanResponseModel : IPatternPlanRequestModel, IBaseRequestModel, IBaseResponseModel
{
    public IEnumerable<AssembledPatternTaskResponseModel> Tasks { get; }
}
