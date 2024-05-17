using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Services.Parents;

namespace InternsAdaptationService.Infrastructure.Services.Patterns;

public class PatternPlanService : BaseService<PatternPlanEntity>, IPatternPlanService
{
    private readonly IPatternPlanRepository _patternPlanRepository;

    public PatternPlanService(IPatternPlanRepository patternTaskRepository) : base(patternTaskRepository)
    {
        _patternPlanRepository = patternTaskRepository;
    }

    public async Task<IEnumerable<PatternPlanEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _patternPlanRepository.GetByMentorIdAsync(id);
    }
}
