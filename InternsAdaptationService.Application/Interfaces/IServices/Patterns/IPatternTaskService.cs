using InternsAdaptationService.Application.Interfaces.IServices.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;

namespace InternsAdaptationService.Application.Interfaces.IServices.Patterns;

public interface IPatternTaskService : IBaseService<PatternTaskEntity>
{
    public Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id);
}
