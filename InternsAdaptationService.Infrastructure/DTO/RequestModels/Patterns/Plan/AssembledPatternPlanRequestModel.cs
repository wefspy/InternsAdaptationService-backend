using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;

public class AssembledPatternPlanRequestModel : IBaseRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public IEnumerable<BodyAssembledPatternTaskRequestModel> Tasks { get; }

    public AssembledPatternPlanRequestModel(Guid mentorId, string title, IEnumerable<BodyAssembledPatternTaskRequestModel> tasks)
    {
        MentorId = mentorId;
        Title = title;
        Tasks = tasks;
    }
}
