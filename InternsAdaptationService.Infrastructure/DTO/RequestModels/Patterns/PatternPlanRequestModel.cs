using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;

public class PatternPlanRequestModel : IPatternPlanRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public PatternPlanRequestModel(Guid mentorId, string title)
    {
        MentorId = mentorId;
        Title = title;
    }
}
