namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;

public interface IPatternPlanRequestModel : IBaseRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

}
