using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Data.Interfaces.IRepositories;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Services.Pattern;

namespace InternsAdaptationService.Infrastructure.Services.Patterns;

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
