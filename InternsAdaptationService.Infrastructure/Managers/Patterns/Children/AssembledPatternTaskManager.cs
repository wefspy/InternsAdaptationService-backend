using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Infrastructure.Managers.Patterns.Children;

public class AssembledPatternTaskManager : IAssembledPatternTaskManager
{
    private readonly IPatternPlanTaskManager _patternPlanTaskManager;
    private readonly IPatternTaskManager _patternTaskManager;
    private readonly IAssembledPatternTaskMapper _assembledPatternTaskMapper;

    public AssembledPatternTaskManager(IPatternPlanTaskManager patternPlanTaskManager, IPatternTaskManager patternTaskManager, 
        IAssembledPatternTaskMapper assembledPatternTaskMapper)
    {
        _patternPlanTaskManager = patternPlanTaskManager;
        _patternTaskManager = patternTaskManager;
        _assembledPatternTaskMapper = assembledPatternTaskMapper;
    }

    public Task<IEnumerable<AssembledPatternTaskResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AssembledPatternTaskResponseModel> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<AssembledPatternTaskResponseModel> CreateAsync(AssembledPatternTaskRequestModel request)
    {
        async Task<PatternTaskResponseModel> CreateTask(AssembledPatternTaskRequestModel request)
        {
            var patternTaskRequest = _assembledPatternTaskMapper.ToPatternTaskRequestModel(request);
            return await _patternTaskManager.CreateAsync(patternTaskRequest);
        }

        PatternTaskResponseModel patternTaskResponse;
        if (!request.Reusable)
            patternTaskResponse = await CreateTask(request);
        else
        {
            try
            {
                patternTaskResponse = await _patternTaskManager.GetByIdAsync(request.Id);
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

    public IEnumerable<AssembledPatternTaskResponseModel> CreateRange(IEnumerable<AssembledPatternTaskRequestModel> requests)
    {
        var tasks = requests.Select(request => CreateAsync(request).Result);

        return tasks;
    }

    public Task UpdateAsync(Guid id, AssembledPatternTaskRequestModel request)
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

    Task IBaseManager<AssembledPatternTaskRequestModel, AssembledPatternTaskResponseModel>.CreateRangeAsync(IEnumerable<AssembledPatternTaskRequestModel> requests)
    {
        throw new NotImplementedException();
    }
}