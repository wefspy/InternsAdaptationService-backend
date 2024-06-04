using InternsAdaptationService.Infrastructure.DTO.Objects.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IObjects.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Children;

public class AssembledPatternPlanRequestModel : IAssembledPatternPlanRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public IEnumerable<AssembledPatternTaskObject> Tasks { get; }

    public AssembledPatternPlanRequestModel(Guid mentorId, string title, IEnumerable<AssembledPatternTaskObject> tasks)
    {
        MentorId = mentorId;
        Title = title;
        Tasks = tasks;
    }
}
