namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;

public interface IInternshipTaskRequestModel : IBaseRequestModel
{
    public Guid InternId { get; }

    public string Title { get; }

    public string Description { get; }

    public DateTime StartDate { get; }

    public DateTime EndDate { get; }

    public DateTime? CompletionDate { get; }

    public Guid AuthorId { get; }

    public string? MentorReview { get; }

    public int Progress { get; }

}
