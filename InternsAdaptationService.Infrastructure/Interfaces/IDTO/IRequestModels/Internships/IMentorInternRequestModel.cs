namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;

public interface IMentorInternRequestModel : IBaseRequestModel
{
    public Guid MentorId { get; }

    public Guid InternId { get; }

}
