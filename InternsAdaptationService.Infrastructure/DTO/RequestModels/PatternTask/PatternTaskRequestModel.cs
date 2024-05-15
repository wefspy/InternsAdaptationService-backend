namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.PatternTask;

public class PatternTaskRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public string Description { get; }

    public PatternTaskRequestModel(Guid mentorId, string title, string description)
    {
        MentorId = mentorId;
        Title = title;
        Description = description;
    }
}
