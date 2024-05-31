using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;

public class AssembledPatternTaskRequestModel : BodyAssembledPatternTaskRequestModel, IBaseRequestModel
{
    public Guid MentorId { get; }

    public Guid PlanId { get; }


    public AssembledPatternTaskRequestModel(Guid id, Guid mentorId, Guid planId, string title, string description,
        int startDate, int endDate, bool reusable) : base(id, title, description, reusable, startDate, endDate)
    {
        MentorId = mentorId;
        PlanId = planId;
    }
}
