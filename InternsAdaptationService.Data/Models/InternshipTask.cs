using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Data.Models.Parents;

namespace InternsAdaptationService.Data.Models;

public class InternshipTask: BaseModel
{
    public required Guid InternID { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime Deadline { get; set; }

    public required DateTime CompletionDate { get; set; }

    public required Guid Author { get; set; }

    public string? MentorReview { get; set; }

    public required StatusEnum Status { get; set; }

    public virtual User Intern { get; set; }

}
