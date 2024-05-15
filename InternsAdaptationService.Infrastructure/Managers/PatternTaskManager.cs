using InternsAdaptationService.Infrastructure.DTO.RequestModels.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.PatternTask;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers;
using InternsAdaptationService.Infrastructure.Interfaces.IServices;

namespace InternsAdaptationService.Infrastructure.Managers;

public class PatternTaskManager : IPatternTaskManager
{
    private readonly IPatternTaskService _patternTaskService;
    private readonly IPatternTaskMapper _patternTaskMapper;


    public PatternTaskManager(IPatternTaskService patternTaskService, IPatternTaskMapper patternTaskMapper)
    {
        _patternTaskService = patternTaskService;
        _patternTaskMapper = patternTaskMapper;
    }

    public async Task<PatternTaskResponseModel> CreateAsync(PatternTaskRequestModel request)
    {
        var newEntity = _patternTaskMapper.ToNewEntity(request);

        var created = await _patternTaskService.CreateAsync(newEntity);

        return _patternTaskMapper.ToResponse(created);
    }

    public async Task UpdateAsync(Guid id, PatternTaskRequestModel request)
    {
        var existEntity = _patternTaskMapper.ToExistEntity(id, request);

        await _patternTaskService.UpdateAsync(existEntity);
    }

    public async Task<IEnumerable<PatternTaskResponseModel>> GetAllAsync()
    {
        var entities = await _patternTaskService.GetAllAsync();

        return entities.Select(entity => _patternTaskMapper.ToResponse(entity));
    }

    public async Task<PatternTaskResponseModel> GetByIdAsync(Guid id)
    {
        var entity = await _patternTaskService.GetByIdAsync(id);

        return _patternTaskMapper.ToResponse(entity);
    }

    public async Task<IEnumerable<PatternTaskResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _patternTaskService.GetByMentorIdAsync(id);

        return entities.Select(entity => _patternTaskMapper.ToResponse(entity));
    }

    public async Task DeleteAsync(Guid id)
    {
        await _patternTaskService.DeleteAsync(id);
    }
}
