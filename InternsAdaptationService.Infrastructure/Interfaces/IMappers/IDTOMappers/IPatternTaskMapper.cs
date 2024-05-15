using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.PatternTask;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers;

public interface IPatternTaskMapper
{
    public PatternTaskEntity ToNewEntity(PatternTaskRequestModel request);

    public PatternTaskEntity ToExistEntity(Guid id, PatternTaskRequestModel request);

    public PatternTaskResponseModel ToResponse(PatternTaskEntity entity);
}
