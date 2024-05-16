using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;

public interface IPatternPlanService: IBaseService<PatternPlanEntity>
{
    public Task<IEnumerable<PatternPlanEntity>> GetByMentorIdAsync(Guid id);
}
