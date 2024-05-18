using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;

public class MentorInternRequestModel : IBaseRequestModel
{
    public Guid MentorId { get; }

    public Guid InternId { get; }

    public MentorInternRequestModel(Guid mentorId, Guid internId)
    {
        MentorId = mentorId;
        InternId = internId;
    }
}
