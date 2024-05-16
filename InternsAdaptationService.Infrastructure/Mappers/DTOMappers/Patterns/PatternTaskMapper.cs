using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PatternTask;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;

public class PatternTaskMapper : IPatternTaskMapper
{
    public PatternTaskEntity ToNewEntity(PatternTaskRequestModel request)
    {
        var entity = ToEntity(request);
        entity.Id = Guid.NewGuid();

        return entity;
    }

    public PatternTaskEntity ToExistEntity(Guid id, PatternTaskRequestModel request)
    {
        var entity = ToEntity(request);
        entity.Id = id;

        return entity;
    }

    private PatternTaskEntity ToEntity(PatternTaskRequestModel request)
    {
        return new PatternTaskEntity
        {
            MentorId = request.MentorId,
            Title = request.Title,
            Description = request.Description,
        };
    }

    public PatternTaskResponseModel ToResponse(PatternTaskEntity entity)
    {
        return new PatternTaskResponseModel(entity.Id, entity.MentorId, entity.Title, entity.Description);
    }
}
