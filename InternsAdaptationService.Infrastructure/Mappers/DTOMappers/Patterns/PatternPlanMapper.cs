using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;

public class PatternPlanMapper : BaseDTOMapper<PatternPlanEntity, IPatternPlanRequestModel, IPatternPlanResponseModel>,
    IPatternPlanMapper
{
    protected override PatternPlanEntity ToEntity(IPatternPlanRequestModel request)
    {
        return new PatternPlanEntity
        {
            MentorId = request.MentorId,
            Title = request.Title,
        };
    }

    public override IPatternPlanResponseModel ToResponse(PatternPlanEntity entity)
    {
        return new PatternPlanResponseModel(entity.Id, entity.MentorId, entity.Title);
    }
}
