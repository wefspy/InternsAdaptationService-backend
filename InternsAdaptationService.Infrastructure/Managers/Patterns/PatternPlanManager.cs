using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Patterns;
using InternsAdaptationService.Infrastructure.Managers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Managers.Patterns;

public class PatternPlanManager : BaseManager<PatternPlanEntity, PatternPlanRequestModel, PatternPlanResponseModel>, 
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

    public async Task<IEnumerable<PatternPlanResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _patternPlanService.GetByMentorIdAsync(id);

        return entities.Select(entity => _patternPlanMapper.ToResponse(entity));
    }
}
