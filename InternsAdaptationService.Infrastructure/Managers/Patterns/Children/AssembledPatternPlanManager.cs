using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Infrastructure.Managers.Patterns.Children;

public class AssembledPatternPlanManager : IAssembledPatternPlanManager
{
    private readonly IPatternPlanManager _patternPlanManager;
    private readonly IPatternPlanTaskManager _patternPlanTaskManager;
    private readonly IPatternTaskManager _patternTaskManager;
    private readonly IInternshipTaskManager _internshipTaskManager;
    private readonly IInternshipTaskMapper _internshipTaskMapper;
    private readonly IAssembledPatternPlanMapper _assembledPatternPlanMapper;
    private readonly IAssembledPatternTaskManager _assembledPatternTaskManager;
    private readonly IAssembledPatternTaskMapper _assembledPatternTaskMapper;

    public AssembledPatternPlanManager(IPatternPlanManager patternPlanManager, IAssembledPatternPlanMapper assembledPatternPlanMapper,
        IPatternPlanTaskManager patternPlanTaskManager, IAssembledPatternTaskManager assembledPatternTaskManager,
        IInternshipTaskMapper internshipTaskMapper, IInternshipTaskManager internshipTaskManager, IPatternTaskManager patternTaskManager, 
        IAssembledPatternTaskMapper assembledPatternTaskMapper)
    {
        _patternPlanManager = patternPlanManager;
        _patternPlanTaskManager = patternPlanTaskManager;
        _patternTaskManager = patternTaskManager;
        _internshipTaskManager = internshipTaskManager;
        _internshipTaskMapper = internshipTaskMapper;
        _assembledPatternPlanMapper = assembledPatternPlanMapper;
        _assembledPatternTaskManager = assembledPatternTaskManager;
        _assembledPatternTaskMapper = assembledPatternTaskMapper;
    }

    public Task<IEnumerable<AssembledPatternPlanResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AssembledPatternPlanResponseModel> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<AssembledPatternPlanResponseModel> CreateAsync(AssembledPatternPlanRequestModel request)
    {
        var patternPlanRequest = _assembledPatternPlanMapper.ToPatternPlanRequestModel(request);
        var patternPlanResponse = await _patternPlanManager.CreateAsync(patternPlanRequest);

        var assembledTasksRequest = request.Tasks.Select(task => _assembledPatternTaskMapper.ToRequest(task, patternPlanResponse));
        var assembledTasksResponse = _assembledPatternTaskManager.CreateRange(assembledTasksRequest);

        return _assembledPatternPlanMapper.ToResponse(patternPlanResponse, assembledTasksResponse);
    }

    public Task CreateRangeAsync(IEnumerable<AssembledPatternPlanRequestModel> requests)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, AssembledPatternPlanRequestModel request)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRangeAsync(IEnumerable<Guid> ids)
    {
        throw new NotImplementedException();
    }

    public async Task LoadAsync(Guid id, Guid internId)
    {
        var planTasks = await _patternPlanTaskManager.GetByPlanIdAsync(id);
        var tasks = planTasks.Select(async planTask =>
        {
            var task = await _patternTaskManager.GetByIdAsync(planTask.TaskId);
            return _internshipTaskMapper.ToRequest(internId, planTask, task);
        });

        var internshipTaskRequestModels = await Task.WhenAll(tasks);
        await _internshipTaskManager.CreateRangeAsync(internshipTaskRequestModels);
    }
}
