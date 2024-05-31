using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;

public interface IPatternPlanTaskManager : IBaseManager<PatternPlanTaskRequestModel, PatternPlanTaskResponseModel>
{
    public Task<IEnumerable<PatternPlanTaskResponseModel>> GetByPlanIdAsync(Guid id);
}
