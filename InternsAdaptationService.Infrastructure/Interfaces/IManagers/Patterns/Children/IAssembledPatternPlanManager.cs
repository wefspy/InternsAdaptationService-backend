using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns.Children;

public interface IAssembledPatternPlanManager : IBaseManager<AssembledPatternPlanRequestModel, AssembledPatternPlanResponseModel>
{
    public Task LoadAsync(Guid id, Guid internId);
}
