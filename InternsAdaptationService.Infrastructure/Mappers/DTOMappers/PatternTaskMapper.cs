using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.PatternTask;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers;

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
