using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;

public class PatternPlanTaskRequestModel : IBaseRequestModel
{
    public Guid PlanId { get; }

    public Guid TaskId { get; }

    public DateTime StartDate { get; }

    public DateTime EndDate { get; }

    public PatternPlanTaskRequestModel(Guid planId, Guid taskId, DateTime startDate, DateTime endDate)
    {
        PlanId = planId;
        TaskId = taskId;
        StartDate = startDate;
        EndDate = endDate;
    }
}
