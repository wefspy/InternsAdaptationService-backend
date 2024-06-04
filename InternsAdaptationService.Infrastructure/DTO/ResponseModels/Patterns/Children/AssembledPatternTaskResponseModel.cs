using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Children;

public class AssembledPatternTaskResponseModel : AssembledPatternTaskRequestModel, IAssembledPatternTaskResponseModel
{
    public Guid Id { get; }

    public AssembledPatternTaskResponseModel(Guid planId, Guid id, Guid mentorId, string title, string description,
        bool reusable, int startDate, int endDate)
        : base(planId, id, mentorId, title, description, reusable, startDate, endDate)
    {
        Id = id;
    }
}
