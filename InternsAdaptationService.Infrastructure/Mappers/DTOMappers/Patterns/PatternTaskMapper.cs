using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;

public class PatternTaskMapper : BaseDTOMapper<PatternTaskEntity, IPatternTaskRequestModel, IPatternTaskResponseModel>,
    IPatternTaskMapper
{
    protected override PatternTaskEntity ToEntity(IPatternTaskRequestModel request)
    {
        return new PatternTaskEntity
        {
            MentorId = request.MentorId,
            Title = request.Title,
            Description = request.Description,
            Reusable = request.Reusable,
        };
    }

    public override IPatternTaskResponseModel ToResponse(PatternTaskEntity entity)
    {
        return new PatternTaskResponseModel(entity.Id, entity.MentorId, entity.Title, entity.Description, entity.Reusable);
    }
}
