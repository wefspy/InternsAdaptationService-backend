using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Data.Interfaces.IRepositories;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.PatternTask;
using InternsAdaptationService.Infrastructure.Interfaces.IServices;

namespace InternsAdaptationService.Infrastructure.Services;

public class PatternTaskService : IPatternTaskService
{
    private readonly IPatternTaskRepository _patternTaskRepository;

    public PatternTaskService(IPatternTaskRepository patternTaskRepository)
    {
        _patternTaskRepository = patternTaskRepository;
    }

    public async Task<PatternTaskEntity> CreateAsync(PatternTaskEntity request)
    {
        return await _patternTaskRepository.CreateAsync(request);
    }

    public async Task UpdateAsync(PatternTaskEntity request)
    {
        await _patternTaskRepository.UpdateAsync(request);
    }

    public async Task<IEnumerable<PatternTaskEntity>> GetAllAsync()
    {
        return await _patternTaskRepository.GetAllAsync();
    }

    public async Task<PatternTaskEntity> GetByIdAsync(Guid id)
    {
        return await _patternTaskRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _patternTaskRepository.GetByMentorIdAsync(id);
    }

    public async Task DeleteAsync(Guid id)
    {
        var existEntity = await GetByIdAsync(id);

        await _patternTaskRepository.DeleteAsync(existEntity);
    } 
}
