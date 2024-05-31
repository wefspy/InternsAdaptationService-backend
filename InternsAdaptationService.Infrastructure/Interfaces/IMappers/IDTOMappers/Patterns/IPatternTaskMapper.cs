using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IPatternTaskMapper : IBaseDTOMapper<PatternTaskEntity, PatternTaskRequestModel, PatternTaskResponseModel>
{
}
