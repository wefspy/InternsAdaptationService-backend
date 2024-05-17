using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;

public interface IPatternPlanTaskService : IBaseService<PatternPlanTaskEntity>
{
    public Task CreateRangeAsync(PatternPlanTaskEntity[] entities);

    public Task<IEnumerable<PatternPlanTaskEntity>> GetByPlanIdAsync(Guid id);
}
