using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;

public class AssembledPatternPlanResponseModel : AssembledPatternPlanRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public AssembledPatternPlanResponseModel(Guid id, Guid mentorId, string title, 
        IEnumerable<AssembledPatternTaskRequestModel> tasks) : base(mentorId, title, tasks)
    {
        Id = id;
    }
}
