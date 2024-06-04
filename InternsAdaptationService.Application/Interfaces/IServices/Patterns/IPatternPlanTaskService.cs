using InternsAdaptationService.Application.Interfaces.IServices.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;

namespace InternsAdaptationService.Application.Interfaces.IServices.Patterns;

public interface IPatternPlanTaskService : IBaseService<PatternPlanTaskEntity>
{
    public Task<IEnumerable<PatternPlanTaskEntity>> GetByPlanIdAsync(Guid id);
}
