using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;

public class MentorInternResponseModel : MentorInternRequestModel, IMentorInternResponseModel
{
    public Guid Id { get; }

    public MentorInternResponseModel(Guid id, Guid mentorId, Guid internId) : base(mentorId, internId)
    {
        Id = id;
    }
}
