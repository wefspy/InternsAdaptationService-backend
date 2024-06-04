using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Application.Services.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;

namespace InternsAdaptationService.Application.Services.Patterns;

public class PatternPlanTaskService : BaseService<PatternPlanTaskEntity>, IPatternPlanTaskService
{
    private readonly IPatternPlanTaskRepository _patternPlanTaskRepository;

    public PatternPlanTaskService(IPatternPlanTaskRepository patternPlanTaskRepository) :
        base(patternPlanTaskRepository)
    {
        _patternPlanTaskRepository = patternPlanTaskRepository;
    }

    public async Task<IEnumerable<PatternPlanTaskEntity>> GetByPlanIdAsync(Guid id)
    {
        return await _patternPlanTaskRepository.GetByPlanIdAsync(id);
    }
}
