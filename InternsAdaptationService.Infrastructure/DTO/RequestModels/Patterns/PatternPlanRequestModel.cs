using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;

public class PatternPlanRequestModel : IBaseRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public PatternPlanRequestModel(Guid mentorId, string title)
    {
        MentorId = mentorId;
        Title = title;
    }
}
