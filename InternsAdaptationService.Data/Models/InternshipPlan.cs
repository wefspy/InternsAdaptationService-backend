using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Data.Models.Parents;

namespace InternsAdaptationService.Data.Models;

public class InternshipPlan: BaseModel
{
    public required Guid InternID { get; set; }

    public required string Title { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime Deadline { get; set; }

    public required Status Status { get; set; }

    public virtual Intern Intern { get; set; }
}
