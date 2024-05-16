using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Parents;

namespace InternsAdaptationService.Data.Interfaces.IRepositories;

public interface IPatternTaskRepository : IBaseRepository<PatternTaskEntity>
{
    public Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id);
}
