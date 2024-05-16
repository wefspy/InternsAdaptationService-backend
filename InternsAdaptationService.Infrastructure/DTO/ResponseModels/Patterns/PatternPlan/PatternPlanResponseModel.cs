using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PatternPlan;

public class PatternPlanResponseModel : PatternPlanRequestModel
{
    public Guid PlanId { get; }

    public PatternPlanResponseModel(Guid planId, Guid mentorId, string title) : base(mentorId, title)
    {
        PlanId = planId;
    }
}
