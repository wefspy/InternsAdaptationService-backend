using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

public class PatternTaskResponseModel : PatternTaskRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public PatternTaskResponseModel(Guid id, Guid mentorId, string title, string description)
        : base(mentorId, title, description)
    {
        Id = id;
    }
}
