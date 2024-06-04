using InternsAdaptationService.Application.Interfaces.IManagers.Patterns.Children;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

namespace InternsAdaptationService.Application.Managers.Patterns.Children;

public class AssembledPatternPlanManager : IAssembledPatternPlanManager
{
    private readonly IAssembledPatternPlanService _assembledPatternPlanService;

    public AssembledPatternPlanManager(IAssembledPatternPlanService assembledPatternPlanService)
    {
        _assembledPatternPlanService = assembledPatternPlanService;
    }

    public async Task<IAssembledPatternPlanResponseModel> CreateAsync(IAssembledPatternPlanRequestModel request)
    {
        var result = await _assembledPatternPlanService.CreateAsync(request);

        await _assembledPatternPlanService.SaveAsync();

        return result;
    }

    public async Task LoadAsync(Guid id, Guid internId)
    {
        await _assembledPatternPlanService.LoadAsync(id, internId);

        await _assembledPatternPlanService.SaveAsync();
    }
}
