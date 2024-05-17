using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;

public class PatternTaskRequestModel : IBaseRequestModel
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
