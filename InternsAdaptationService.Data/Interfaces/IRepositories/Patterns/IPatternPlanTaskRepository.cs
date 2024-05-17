using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Parents;

namespace InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;

public interface IPatternPlanTaskRepository : IBaseRepository<PatternPlanTaskEntity>
{
    public Task CreateRangeAsync(PatternPlanTaskEntity[] entities);

    public Task<IEnumerable<PatternPlanTaskEntity>> GetByPlanIdAsync(Guid id);
}
