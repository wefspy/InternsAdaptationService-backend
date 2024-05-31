using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;

public class PatternPlanTaskResponseModel : PatternPlanTaskRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public PatternPlanTaskResponseModel(Guid id, Guid planId, Guid taskId, int startDate, int endDate) :
        base(planId, taskId, startDate, endDate)
    {
        Id = id;
    }
}
