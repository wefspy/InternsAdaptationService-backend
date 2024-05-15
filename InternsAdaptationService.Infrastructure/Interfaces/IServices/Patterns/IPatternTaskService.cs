using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Parent;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;

public interface IPatternTaskService : IBaseService<PatternTaskEntity>
{
    public Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id);
}
