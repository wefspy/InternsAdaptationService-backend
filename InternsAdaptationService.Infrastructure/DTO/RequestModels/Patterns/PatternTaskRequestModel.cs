using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;

public class PatternTaskRequestModel : IPatternTaskRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public string Description { get; }

    public bool Reusable { get; }

    public PatternTaskRequestModel(Guid mentorId, string title, string description, bool reusable)
    {
        MentorId = mentorId;
        Title = title;
        Description = description;
        Reusable = reusable;
    }
}
