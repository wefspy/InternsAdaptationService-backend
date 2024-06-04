using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

namespace InternsAdaptationService.Application.Interfaces.IServices.Patterns.Children;

public interface IAssembledPatternPlanService
{
    public Task<IAssembledPatternPlanResponseModel> CreateAsync(IAssembledPatternPlanRequestModel request);

    public Task LoadAsync(Guid id, Guid internId);

    public Task SaveAsync();
}
