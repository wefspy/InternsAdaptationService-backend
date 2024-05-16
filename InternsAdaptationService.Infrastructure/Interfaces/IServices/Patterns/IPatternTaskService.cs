using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;

public interface IPatternTaskService : IBaseService<PatternTaskEntity>
{
    public Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id);
}
