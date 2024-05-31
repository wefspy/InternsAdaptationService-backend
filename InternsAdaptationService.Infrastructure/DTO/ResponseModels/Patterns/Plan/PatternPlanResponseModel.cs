using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;

public class PatternPlanResponseModel : PatternPlanRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public PatternPlanResponseModel(Guid id, Guid mentorId, string title) : base(mentorId, title)
    {
        Id = id;
    }
}
