using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;

public class PatternPlanTaskRequestModel : IBaseRequestModel
{
    public Guid PlanId { get; }

    public Guid TaskId { get; }

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
