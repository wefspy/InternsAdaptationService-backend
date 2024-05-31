using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;

public class AssembledPatternTaskRequestModel : PatternTaskRequestModel, IBaseRequestModel
{
    public Guid Id { get; } = Guid.Empty;

    public Guid PlanId { get; }

    public int StartDate { get; }

    public int EndDate { get; }

    public AssembledPatternTaskRequestModel(Guid id, Guid mentorId, Guid planId, string title, string description,
        int startDate, int endDate, bool reusable) : base(mentorId, title, description, reusable)
    {
        Id = id;
        PlanId = planId;
        StartDate = startDate;
        EndDate = endDate;
    }
}
