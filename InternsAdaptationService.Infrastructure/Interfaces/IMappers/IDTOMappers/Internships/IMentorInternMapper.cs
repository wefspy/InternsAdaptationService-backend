using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;

public interface IMentorInternMapper : IBaseDTOMapper<MentorInternEntity, IMentorInternRequestModel, IMentorInternResponseModel>
{
}
