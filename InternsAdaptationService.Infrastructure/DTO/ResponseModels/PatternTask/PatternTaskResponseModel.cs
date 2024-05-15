using InternsAdaptationService.Infrastructure.DTO.RequestModels.PatternTask;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.PatternTask;

public class PatternTaskResponseModel : PatternTaskRequestModel
{
    public Guid TaskId { get; }

    public PatternTaskResponseModel(Guid taskId, Guid mentorId, string title, string description) 
        : base(mentorId, title, description)
    {
        TaskId = taskId;
    }
}
