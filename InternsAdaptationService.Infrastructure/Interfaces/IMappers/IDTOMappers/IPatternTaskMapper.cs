using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.PatternTask;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers;

public interface IPatternTaskMapper : IBaseDTOMapper<PatternTaskEntity, PatternTaskRequestModel, PatternTaskResponseModel>
{
}
