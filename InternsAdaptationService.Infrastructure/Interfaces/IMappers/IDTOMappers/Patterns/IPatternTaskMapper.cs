using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PatternTask;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IPatternTaskMapper : IBaseDTOMapper<PatternTaskEntity, PatternTaskRequestModel, PatternTaskResponseModel>
{
}
