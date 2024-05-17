using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternPlan;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

public class PatternPlanResponseModel : PatternPlanRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public PatternPlanResponseModel(Guid id, Guid mentorId, string title) : base(mentorId, title)
    {
        Id = id;
    }
}
