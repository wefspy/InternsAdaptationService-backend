using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Managers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Managers.Patterns;

public class PatternPlanTaskManager : BaseManager<PatternPlanTaskEntity, PatternPlanTaskRequestModel, PatternPlanTaskResponseModel>,
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

    public async Task<IEnumerable<PatternPlanTaskResponseModel>> GetByPlanIdAsync(Guid id)
    {
        var entities = await _patternPlanTaskService.GetByPlanIdAsync(id);

        return entities
            .Select(entity => _patternPlanTaskMapper.ToResponse(entity))
            .ToArray();
    }
}
