using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

namespace InternsAdaptationService.Application.Interfaces.IServices.Patterns.Children;

public interface IAssembledPatternTaskService
{
    public Task<IAssembledPatternTaskResponseModel> CreateAsync(IAssembledPatternTaskRequestModel request);

    public Task<IEnumerable<IAssembledPatternTaskResponseModel>> CreateRangeAsync(IEnumerable<IAssembledPatternTaskRequestModel> requests);

    public Task SaveAsync();
}
