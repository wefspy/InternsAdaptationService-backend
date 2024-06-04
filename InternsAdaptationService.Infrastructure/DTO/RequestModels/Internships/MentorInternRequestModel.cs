using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;

public class MentorInternRequestModel : IMentorInternRequestModel
{
    public Guid MentorId { get; }

    public Guid InternId { get; }

    public MentorInternRequestModel(Guid mentorId, Guid internId)
    {
        MentorId = mentorId;
        InternId = internId;
    }
}
