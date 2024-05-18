using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Abstracts;

namespace InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;

public interface IPatternPlanRepository : IBaseRepository<PatternPlanEntity>
{
    public Task<IEnumerable<PatternPlanEntity>> GetByMentorIdAsync(Guid id);
}
