using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;

public interface IPatternPlanManager : IBaseManager<PatternPlanRequestModel, PatternPlanResponseModel>
{
    public Task<IEnumerable<PatternPlanResponseModel>> GetByMentorIdAsync(Guid id);
}
