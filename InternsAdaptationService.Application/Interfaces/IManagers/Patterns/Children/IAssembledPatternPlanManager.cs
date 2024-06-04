using InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Patterns.Children;

public interface IAssembledPatternPlanManager
{
    public Task<IAssembledPatternPlanResponseModel> CreateAsync(IAssembledPatternPlanRequestModel request);

    public Task LoadAsync(Guid id, Guid internId);
}
