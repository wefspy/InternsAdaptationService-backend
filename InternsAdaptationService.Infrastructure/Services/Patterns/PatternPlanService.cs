using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Data.Interfaces.IRepositories;

namespace InternsAdaptationService.Infrastructure.Services.Patterns;

public class PatternPlanService
{
    private readonly IPatternPlanRepository _patternPlanRepository;

    public PatternPlanService(IPatternPlanRepository patternTaskRepository)
    {
        _patternPlanRepository = patternTaskRepository;
    }

    public async Task<PatternPlanEntity> CreateAsync(PatternPlanEntity request)
    {
        return await _patternPlanRepository.CreateAsync(request);
    }

    public async Task UpdateAsync(PatternPlanEntity request)
    {
        await _patternPlanRepository.UpdateAsync(request);
    }

    public async Task<IEnumerable<PatternPlanEntity>> GetAllAsync()
    {
        return await _patternPlanRepository.GetAllAsync();
    }

    public async Task<PatternPlanEntity> GetByIdAsync(Guid id)
    {
        return await _patternPlanRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<PatternPlanEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _patternPlanRepository.GetByMentorIdAsync(id);
    }

    public async Task DeleteAsync(Guid id)
    {
        var existEntity = await GetByIdAsync(id);

        await _patternPlanRepository.DeleteAsync(existEntity);
    }
}
