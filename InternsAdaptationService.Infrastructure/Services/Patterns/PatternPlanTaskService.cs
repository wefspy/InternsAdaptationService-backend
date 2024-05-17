using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Services.Parents;

namespace InternsAdaptationService.Infrastructure.Services.Patterns;

public class PatternPlanTaskService : BaseService<PatternPlanTaskEntity>, IPatternPlanTaskService
{
    private readonly IPatternPlanTaskRepository _patternPlanTaskRepository;

    public PatternPlanTaskService(IPatternPlanTaskRepository patternPlanTaskRepository) :
        base(patternPlanTaskRepository)
    {
        _patternPlanTaskRepository = patternPlanTaskRepository;
    }

    public async Task CreateRangeAsync(PatternPlanTaskEntity[] entities)
    {
        await _patternPlanTaskRepository.CreateRangeAsync(entities);
    }

    public Task<IEnumerable<PatternPlanTaskEntity>> GetByPlanIdAsync(Guid id)
    {
        return _patternPlanTaskRepository.GetByPlanIdAsync(id);
    }
}
