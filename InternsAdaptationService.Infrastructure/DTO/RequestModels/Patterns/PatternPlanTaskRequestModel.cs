using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;

public class PatternPlanTaskRequestModel : IPatternPlanTaskRequestModel
{
    public Guid PlanId { get; }

    public Guid TaskId { get; set; }

    public int StartDate { get; }

    public int EndDate { get; }

    public PatternPlanTaskRequestModel(Guid planId, Guid taskId, int startDate, int endDate)
    {
        PlanId = planId;
        TaskId = taskId;
        StartDate = startDate;
        EndDate = endDate;
    }
}
