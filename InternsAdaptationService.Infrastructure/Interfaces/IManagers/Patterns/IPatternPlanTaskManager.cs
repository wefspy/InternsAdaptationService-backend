using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;

public interface IPatternPlanTaskManager : IBaseManager<PatternPlanTaskRequestModel, PatternPlanTaskResponseModel>
{
    public Task CreateRangeAsync(PatternPlanTaskRequestModel[] requests);

    public Task<IEnumerable<PatternPlanTaskResponseModel>> GetByPlanIdAsync(Guid id);
}
