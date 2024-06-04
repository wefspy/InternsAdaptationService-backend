using InternsAdaptationService.Application.Interfaces.IManagers.Patterns.Children;
using InternsAdaptationService.Application.Interfaces.IServices.Internships;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Application.Services.Patterns.Children;

public class AssembledPatternPlanService : IAssembledPatternPlanService
{
    private readonly IPatternPlanService _patternPlanService;
    private readonly IPatternPlanMapper _patternPlanMapper;
    private readonly IPatternPlanTaskService _patternPlanTaskService;
    private readonly IPatternTaskService _patternTaskService;
    private readonly IInternshipTaskService _internshipTaskService;
    private readonly IAssembledPatternTaskManager _assembledPatternTaskService;
    private readonly IInternshipTaskMapper _internshipTaskMapper;
    private readonly IAssembledPatternPlanMapper _assembledPatternPlanMapper;
    private readonly IAssembledPatternTaskMapper _assembledPatternTaskMapper;

    public AssembledPatternPlanService(IPatternPlanService patternPlanService, IPatternPlanMapper patternPlanMapper, IAssembledPatternPlanMapper assembledPatternPlanMapper,
        IPatternPlanTaskService patternPlanTaskService, IAssembledPatternTaskManager assembledPatternTaskService,
        IInternshipTaskMapper internshipTaskMapper, IInternshipTaskService internshipTaskService, IPatternTaskService patternTaskService,
        IAssembledPatternTaskMapper assembledPatternTaskMapper)
    {
        _patternPlanService = patternPlanService;
        _patternPlanMapper = patternPlanMapper;
        _patternPlanTaskService = patternPlanTaskService;
        _patternTaskService = patternTaskService;
        _internshipTaskService = internshipTaskService;
        _assembledPatternTaskService = assembledPatternTaskService;
        _internshipTaskMapper = internshipTaskMapper;
        _assembledPatternPlanMapper = assembledPatternPlanMapper;
        _assembledPatternTaskMapper = assembledPatternTaskMapper;
    }

    public async Task<IAssembledPatternPlanResponseModel> CreateAsync(IAssembledPatternPlanRequestModel request)
    {
        var patternPlanRequest = _patternPlanMapper.ToNewEntity(request);
        var patternPlanEntity = await _patternPlanService.CreateAsync(patternPlanRequest);

        var assembledTasksRequest = request.Tasks.Select(task => _assembledPatternTaskMapper.ToRequest(task, patternPlanEntity));
        var assembledTaskEntities = await _assembledPatternTaskService.CreateRangeAsync(assembledTasksRequest);

        return _assembledPatternPlanMapper.ToResponse(patternPlanEntity, assembledTaskEntities);
    }

    public async Task LoadAsync(Guid id, Guid internId)
    {
        var planTasks = await _patternPlanTaskService.GetByPlanIdAsync(id);
        var tasks = planTasks.Select(async planTask =>
        {
            var task = await _patternTaskService.GetByIdAsync(planTask.TaskId);
            return _internshipTaskMapper.ToNewEntity(internId, planTask, task);
        });

        var internshipTaskRequestModels = await Task.WhenAll(tasks);
        await _internshipTaskService.CreateRangeAsync(internshipTaskRequestModels);
    }

    public async Task SaveAsync()
    {
        await _internshipTaskService.SaveAsync();
    }
}
