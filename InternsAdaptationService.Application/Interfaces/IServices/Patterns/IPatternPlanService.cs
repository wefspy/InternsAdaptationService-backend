using InternsAdaptationService.Application.Interfaces.IServices.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;

namespace InternsAdaptationService.Application.Interfaces.IServices.Patterns;

public interface IPatternPlanService : IBaseService<PatternPlanEntity>
{
    public Task<IEnumerable<PatternPlanEntity>> GetByMentorIdAsync(Guid id);
}
