using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Managers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Managers.Patterns;

public class PatternPlanManager : BaseManager<PatternPlanEntity, PatternPlanRequestModel, PatternPlanResponseModel>, 
    IPatternPlanManager
{
    private readonly IPatternTaskManager _patternTaskManager;
    private readonly IPatternPlanService _patternPlanService;
    private readonly IPatternPlanMapper _patternPlanMapper;
    private readonly IAssembledPatternPlanMapper _assembledPatternPlanMapper;
    private readonly IAssembledPatternTaskMapper _assembledPatternTaskMapper;
    
    public PatternPlanManager(IPatternPlanService patternPlanService, IPatternPlanMapper patternPlanMapper, IPatternTaskManager patternTaskManager,
        IAssembledPatternPlanMapper assembledPatternPlanMapper, IAssembledPatternTaskMapper assembledPatternTaskMapper) :
        base(patternPlanService, patternPlanMapper)
    {
        _patternPlanService = patternPlanService;
        _patternPlanMapper = patternPlanMapper;
        _patternTaskManager = patternTaskManager;
        _assembledPatternPlanMapper = assembledPatternPlanMapper;
        _assembledPatternTaskMapper = assembledPatternTaskMapper;
    }

    public async Task<IEnumerable<PatternPlanResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _patternPlanService.GetByMentorIdAsync(id);

        return entities.Select(entity => _patternPlanMapper.ToResponse(entity));
    }

    public async Task<AssembledPatternPlanResponseModel> CreateAssembledAsync(AssembledPatternPlanRequestModel request)
    {
        var patternPlanRequest = _assembledPatternPlanMapper.ToPatternPlanRequestModel(request);
        var patternPlanResponse = await CreateAsync(patternPlanRequest);

        var assembledTasksRequest = request.Tasks.Select(task => _assembledPatternTaskMapper.ToRequest(task, patternPlanResponse));
        var assembledTasksResponse = _patternTaskManager.CreateRangeAssembled(assembledTasksRequest);
         
        return _assembledPatternPlanMapper.ToResponse(patternPlanResponse, assembledTasksResponse);
    }
}
