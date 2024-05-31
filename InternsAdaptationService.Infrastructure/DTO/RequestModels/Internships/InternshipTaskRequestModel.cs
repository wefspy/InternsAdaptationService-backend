using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;

public class InternshipTaskRequestModel : IBaseRequestModel
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

    public InternshipTaskRequestModel(Guid internId, string title, string description, DateTime startDate, DateTime endDate, DateTime? completionDate, Guid authorId, string? mentorReview, int progress)
    {
        InternId = internId;
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        CompletionDate = completionDate;
        AuthorId = authorId;
        MentorReview = mentorReview;
        Progress = progress;
    }
}
