namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;

public class PatternPlanRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public PatternPlanRequestModel(Guid mentorId, string title)
    {
        MentorId = mentorId;
        Title = title;
    }
}
