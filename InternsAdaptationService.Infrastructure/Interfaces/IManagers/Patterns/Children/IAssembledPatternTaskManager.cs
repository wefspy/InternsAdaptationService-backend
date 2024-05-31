using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns.Children;

public interface IAssembledPatternTaskManager : IBaseManager<AssembledPatternTaskRequestModel, AssembledPatternTaskResponseModel>
{
    public new Task<IEnumerable<AssembledPatternTaskResponseModel>> CreateRangeAsync(IEnumerable<AssembledPatternTaskRequestModel> requests);
}
