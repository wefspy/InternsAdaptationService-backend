using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Application.Services.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;

namespace InternsAdaptationService.Application.Services.Patterns;

public class PatternTaskService : BaseService<PatternTaskEntity>, IPatternTaskService
{
    private readonly IPatternTaskRepository _patternTaskRepository;

    public PatternTaskService(IPatternTaskRepository patternTaskRepository) : base(patternTaskRepository)
    {
        _patternTaskRepository = patternTaskRepository;
    }

    public async Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _patternTaskRepository.GetByMentorIdAsync(id);
    }
}
