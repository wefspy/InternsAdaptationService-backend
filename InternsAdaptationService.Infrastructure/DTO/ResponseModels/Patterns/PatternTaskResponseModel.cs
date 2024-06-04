using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

public class PatternTaskResponseModel : PatternTaskRequestModel, IPatternTaskResponseModel
{
    public Guid Id { get; }

    public PatternTaskResponseModel(Guid id, Guid mentorId, string title, string description, bool reusable)
        : base(mentorId, title, description, reusable)
    {
        Id = id;
    }
}
