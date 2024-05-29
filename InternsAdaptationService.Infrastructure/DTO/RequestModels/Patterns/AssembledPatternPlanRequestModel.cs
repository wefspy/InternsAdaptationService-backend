using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;

public class AssembledPatternPlanRequestModel : IBaseRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public IEnumerable<AssembledPatternTaskRequestModel> Tasks { get; }

    public AssembledPatternPlanRequestModel(Guid mentorId, string title, IEnumerable<AssembledPatternTaskRequestModel> tasks)
    {
        MentorId = mentorId;
        Title = title;
        Tasks = tasks;
    }
}
