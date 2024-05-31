using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Data.Entities.Abstracts;

namespace InternsAdaptationService.Data.Entities.Internships;

public class InternshipTaskEntity : BaseEntity
{
    public required Guid InternId { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime EndDate { get; set; }

    public required DateTime? CompletionDate { get; set; }

    public required Guid AuthorId { get; set; }

    public string? MentorReview { get; set; }

    public required int Progress { get; set; }

    public virtual UserEntity Intern { get; set; }

    public virtual IEnumerable<InternshipSubtaskEntity> InternshipSubtasks { get; set; }
}
