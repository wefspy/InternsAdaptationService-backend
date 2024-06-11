using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Application.Services.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;


namespace InternsAdaptationService.Application.Services.Patterns;

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

    public async Task<IEnumerable<PatternPlanEntity>> GetFromRoleAsync(string role)
    {
        return await _patternPlanRepository.GetFromRoleAsync(role);
    }
}
