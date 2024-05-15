using InternsAdaptationService.Data.Entities;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices;

public interface IPatternTaskService
{
    public Task<PatternTaskEntity> CreateAsync(PatternTaskEntity request);

    public Task UpdateAsync(PatternTaskEntity request);

    public Task<IEnumerable<PatternTaskEntity>> GetAllAsync();

    public Task<PatternTaskEntity> GetByIdAsync(Guid id);

    public Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id);

    public Task DeleteAsync(Guid id);
}
