namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;

public interface IPatternTaskRequestModel : IBaseRequestModel
{
    public Guid MentorId { get; }

    public string Title { get; }

    public string Description { get; }

    public bool Reusable { get; }

}
