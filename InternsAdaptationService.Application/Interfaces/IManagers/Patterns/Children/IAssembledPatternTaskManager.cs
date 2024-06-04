using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Patterns.Children;

public interface IAssembledPatternTaskManager
{
    public Task<IAssembledPatternTaskResponseModel> CreateAsync(IAssembledPatternTaskRequestModel request);

    public Task<IEnumerable<IAssembledPatternTaskResponseModel>> CreateRangeAsync(IEnumerable<IAssembledPatternTaskRequestModel> requests);
}
