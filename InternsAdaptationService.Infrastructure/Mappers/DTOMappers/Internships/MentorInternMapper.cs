using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Internships;

public class MentorInternMapper : BaseDTOMapper<MentorInternEntity, MentorInternRequestModel, MentorInternResponseModel>,
    IMentorInternMapper
{
    protected override MentorInternEntity ToEntity(MentorInternRequestModel request)
    {
        return new MentorInternEntity
        {
            MentorId = request.MentorId,
            InternId = request.InternId,
        };
    }

    public override MentorInternResponseModel ToResponse(MentorInternEntity entity)
    {
        return new MentorInternResponseModel(entity.Id, entity.MentorId, entity.InternId);
    }
}
