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
    private readonly IAssembledPatternTaskMapper _assembledPatternTaskMapper;
    private readonly IPatternPlanTaskManager _patternPlanTaskManager;

    public PatternTaskManager(IPatternTaskService patternTaskService, IPatternTaskMapper patternTaskMapper,
        IAssembledPatternTaskMapper assembledPatternTaskMapper, IPatternPlanTaskManager patternPlanTaskManager) :
        base(patternTaskService, patternTaskMapper)
    {
        _patternTaskService = patternTaskService;
        _patternTaskMapper = patternTaskMapper;
        _assembledPatternTaskMapper = assembledPatternTaskMapper;
        _patternPlanTaskManager = patternPlanTaskManager;
    }

    public async Task<IEnumerable<PatternTaskResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _patternTaskService.GetByMentorIdAsync(id);

        return entities.Select(entity => _patternTaskMapper.ToResponse(entity));
    }

    public async Task<AssembledPatternTaskResponseModel> CreateAssembledAsync(AssembledPatternTaskRequestModel request)
    {
        async Task<PatternTaskResponseModel> CreateTask(AssembledPatternTaskRequestModel request)
        {
            var patternTaskRequest = _assembledPatternTaskMapper.ToPatternTaskRequestModel(request);
            return await CreateAsync(patternTaskRequest);
        }

        PatternTaskResponseModel patternTaskResponse;
        if (!request.Reusable)
            patternTaskResponse = await CreateTask(request);
        else
        {
            try
            {
                patternTaskResponse = await GetByIdAsync(request.Id);
            }
            catch (Exception)
            {
                patternTaskResponse = await CreateTask(request);
            }
        }

        var patternPlanTaskRequest = _assembledPatternTaskMapper.ToPatternPlanTaskRequestModel(patternTaskResponse.Id, request);
        var patternPlanTaskReponse = await _patternPlanTaskManager.CreateAsync(patternPlanTaskRequest);

        return _assembledPatternTaskMapper.ToResponse(patternPlanTaskReponse, patternTaskResponse);
    }

    public IEnumerable<AssembledPatternTaskResponseModel> CreateRangeAssembled(IEnumerable<AssembledPatternTaskRequestModel> requests)
    {
        return requests.Select(request => CreateAssembledAsync(request).Result);
    }
}
