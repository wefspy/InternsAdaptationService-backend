using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

public class PatternPlanTaskResponseModel : PatternPlanTaskRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public PatternPlanTaskResponseModel(Guid id, Guid planId, Guid taskId, DateTime startDate, DateTime endDate) :
        base(planId, taskId, startDate, endDate)
    {
        Id = id;
    }
}
