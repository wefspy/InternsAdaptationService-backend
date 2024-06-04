using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

public class PatternPlanResponseModel : PatternPlanRequestModel, IPatternPlanResponseModel
{
    public Guid Id { get; }

    public PatternPlanResponseModel(Guid id, Guid mentorId, string title) : base(mentorId, title)
    {
        Id = id;
    }
}
