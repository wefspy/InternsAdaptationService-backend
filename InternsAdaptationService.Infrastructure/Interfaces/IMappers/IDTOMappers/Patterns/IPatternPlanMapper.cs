using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

public interface IPatternPlanMapper : IBaseDTOMapper<PatternPlanEntity, IPatternPlanRequestModel, IPatternPlanResponseModel>
{
}
