using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;

public interface IPatternPlanTaskService : IBaseService<PatternPlanTaskEntity>
{
    public Task<IEnumerable<PatternPlanTaskEntity>> GetByPlanIdAsync(Guid id);
}
