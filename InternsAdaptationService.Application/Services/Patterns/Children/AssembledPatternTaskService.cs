using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns.Children;

namespace InternsAdaptationService.Application.Services.Patterns.Children;

public class AssembledPatternTaskService : IAssembledPatternTaskService
{
    private readonly IPatternPlanTaskService _patternPlanTaskService;
    private readonly IPatternPlanTaskMapper _patternPlanTaskMapper;
    private readonly IPatternTaskService _patternTaskService;
    private readonly IPatternTaskMapper _patternTaskMapper;
    private readonly IAssembledPatternTaskMapper _assembledPatternTaskMapper;

    public AssembledPatternTaskService(IPatternPlanTaskService patternPlanTaskService, IPatternPlanTaskMapper patternPlanTaskMapper,
        IPatternTaskService patternTaskService, IPatternTaskMapper patternTaskMapper, IAssembledPatternTaskMapper assembledPatternTaskMapper)
    {
        _patternPlanTaskService = patternPlanTaskService;
        _patternPlanTaskMapper = patternPlanTaskMapper;
        _patternTaskService = patternTaskService;
        _patternTaskMapper = patternTaskMapper;
        _assembledPatternTaskMapper = assembledPatternTaskMapper;
    }

    public async Task<IAssembledPatternTaskResponseModel> CreateAsync(IAssembledPatternTaskRequestModel request)
    {
        async Task<PatternTaskEntity> CreateTask(IAssembledPatternTaskRequestModel request)
        {
            var entity = _patternTaskMapper.ToNewEntity(request);
            return await _patternTaskService.CreateAsync(entity);
        }

        PatternTaskEntity patternTaskEntity;
        if (!request.Reusable)
            patternTaskEntity = await CreateTask(request);
        else
        {
            try
            {
                patternTaskEntity = await _patternTaskService.GetByIdAsync(request.TaskId);
            }
            catch (Exception)
            {
                patternTaskEntity = await CreateTask(request);
            }
        }

        request.TaskId = patternTaskEntity.Id;
        var patternPlanTaskRequestModel = _patternPlanTaskMapper.ToNewEntity(request);
        var patternPlanTaskEntity = await _patternPlanTaskService.CreateAsync(patternPlanTaskRequestModel);

        return _assembledPatternTaskMapper.ToResponse(patternPlanTaskEntity, patternTaskEntity);
    }

    public async Task<IEnumerable<IAssembledPatternTaskResponseModel>> CreateRangeAsync(IEnumerable<IAssembledPatternTaskRequestModel> requests)
    {
        var tasks = requests.Select(CreateAsync);
        var results = await Task.WhenAll(tasks);

        return results;
    }


    public async Task SaveAsync()
    {
        await _patternTaskService.SaveAsync();
    }
}
