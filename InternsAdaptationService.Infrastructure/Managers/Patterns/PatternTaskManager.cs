using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Managers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Managers.Patterns;

public class PatternTaskManager : BaseManager<PatternTaskEntity, PatternTaskRequestModel, PatternTaskResponseModel>, 
    IPatternTaskManager
{
    private readonly IPatternTaskService _patternTaskService;
    private readonly IPatternTaskMapper _patternTaskMapper;

    public PatternTaskManager(IPatternTaskService patternTaskService, IPatternTaskMapper patternTaskMapper) :
        base(patternTaskService, patternTaskMapper)
    {
        _patternTaskService = patternTaskService;
        _patternTaskMapper = patternTaskMapper;
    }

    public async Task<IEnumerable<PatternTaskResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _patternTaskService.GetByMentorIdAsync(id);

        return entities.Select(entity => _patternTaskMapper.ToResponse(entity));
    }
}
