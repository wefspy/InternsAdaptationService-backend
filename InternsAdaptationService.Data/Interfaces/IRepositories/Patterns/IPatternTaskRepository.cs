using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Abstracts;

namespace InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;

public interface IPatternTaskRepository : IBaseRepository<PatternTaskEntity>
{
    public Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id);
}
