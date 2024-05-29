using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;

public class PatternTaskMapper : BaseDTOMapper<PatternTaskEntity, PatternTaskRequestModel, PatternTaskResponseModel>, 
    IPatternTaskMapper
{
    protected override PatternTaskEntity ToEntity(PatternTaskRequestModel request)
    {
        return new PatternTaskEntity
        {
            MentorId = request.MentorId,
            Title = request.Title,
            Description = request.Description,
            Reusable = request.Reusable,
        };
    }

    public override PatternTaskResponseModel ToResponse(PatternTaskEntity entity)
    {
        return new PatternTaskResponseModel(entity.Id, entity.MentorId, entity.Title, entity.Description, entity.Reusable);
    }
}
