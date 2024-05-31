using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;

public class AssembledPatternPlanResponseModel : AssembledPatternPlanRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public AssembledPatternPlanResponseModel(Guid id, Guid mentorId, string title,
        IEnumerable<BodyAssembledPatternTaskRequestModel> tasks) : base(mentorId, title, tasks)
    {
        Id = id;
    }
}
