using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

public class PatternPlanTaskResponseModel : PatternPlanTaskRequestModel, IPatternPlanTaskResponseModel
{
    public Guid Id { get; }

    public PatternPlanTaskResponseModel(Guid id, Guid planId, Guid taskId, int startDate, int endDate) :
        base(planId, taskId, startDate, endDate)
    {
        Id = id;
    }
}
