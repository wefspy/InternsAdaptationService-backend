using InternsAdaptationService.Application.Interfaces.IManagers.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns.Children;

namespace InternsAdaptationService.Application.Managers.Patterns.Children;

public class AssembledPatternTaskManager : IAssembledPatternTaskManager
{
    private readonly IAssembledPatternTaskService _assembledPatternTaskService;

    public AssembledPatternTaskManager(IAssembledPatternTaskService assembledPatternTaskService)
    {
        _assembledPatternTaskService = assembledPatternTaskService;
    }

    public async Task<IAssembledPatternTaskResponseModel> CreateAsync(IAssembledPatternTaskRequestModel request)
    {
        var result = await _assembledPatternTaskService.CreateAsync(request);

        await _assembledPatternTaskService.SaveAsync();

        return result;
    }

    public async Task<IEnumerable<IAssembledPatternTaskResponseModel>> CreateRangeAsync(IEnumerable<IAssembledPatternTaskRequestModel> requests)
    {
        var result = await _assembledPatternTaskService.CreateRangeAsync(requests);

        await _assembledPatternTaskService.SaveAsync();

        return result;
    }
}
