using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;

public interface IMentorInternMapper : IBaseDTOMapper<MentorInternEntity, MentorInternRequestModel, MentorInternResponseModel>
{
}
