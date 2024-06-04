using InternsAdaptationService.Application.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Application.Managers.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Application.Managers.Patterns;

public class PatternTaskManager : BaseManager<PatternTaskEntity, IPatternTaskRequestModel, IPatternTaskResponseModel>, 
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

    public async Task<IEnumerable<IPatternTaskResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _patternTaskService.GetByMentorIdAsync(id);

        return entities.Select(entity => _patternTaskMapper.ToResponse(entity));
    }
}
