using InternsAdaptationService.Application.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Application.Interfaces.IServices.Patterns;
using InternsAdaptationService.Application.Managers.Abstracts;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Application.Managers.Patterns;

public class PatternPlanManager : BaseManager<PatternPlanEntity, IPatternPlanRequestModel, IPatternPlanResponseModel>,
    IPatternPlanManager
{
    private readonly IPatternPlanService _patternPlanService;
    private readonly IPatternPlanMapper _patternPlanMapper;

    public PatternPlanManager(IPatternPlanService patternPlanService, IPatternPlanMapper patternPlanMapper) :
        base(patternPlanService, patternPlanMapper)
    {
        _patternPlanService = patternPlanService;
        _patternPlanMapper = patternPlanMapper;
    }

    public async Task<IEnumerable<IPatternPlanResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _patternPlanService.GetByMentorIdAsync(id);

        return entities.Select(entity => _patternPlanMapper.ToResponse(entity));
    }
}
