using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Data.Entities.Parents;

namespace InternsAdaptationService.Data.Entities.Internships;

public class InternshipTaskEntity : BaseEntity
{
    public required Guid InternId { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime Deadline { get; set; }

    public required DateTime CompletionDate { get; set; }

    public required Guid Author { get; set; }

    public string? MentorReview { get; set; }

    public required StatusEnum Status { get; set; }

    public virtual UserEntity Intern { get; set; }

}
