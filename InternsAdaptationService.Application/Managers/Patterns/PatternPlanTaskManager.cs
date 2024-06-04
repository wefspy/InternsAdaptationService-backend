using InternsAdaptationService.Application.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Application.Managers.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Application.Managers.Patterns;

public class PatternPlanTaskManager : BaseManager<PatternPlanTaskEntity, IPatternPlanTaskRequestModel, IPatternPlanTaskResponseModel>, 
    IPatternPlanTaskManager
{
    private readonly IPatternPlanTaskService _patternPlanTaskService;
    private readonly IPatternPlanTaskMapper _patternPlanTaskMapper;

    public PatternPlanTaskManager(IPatternPlanTaskService patternPlanTaskService, IPatternPlanTaskMapper patternPlanTaskMapper) :
        base(patternPlanTaskService, patternPlanTaskMapper)
    {
        _patternPlanTaskService = patternPlanTaskService;
        _patternPlanTaskMapper = patternPlanTaskMapper;
    }

    public async Task<IEnumerable<IPatternPlanTaskResponseModel>> GetByPlanIdAsync(Guid id)
    {
        var entities = await _patternPlanTaskService.GetByPlanIdAsync(id);

        return entities
            .Select(entity => _patternPlanTaskMapper.ToResponse(entity))
            .ToArray();
    }
}
