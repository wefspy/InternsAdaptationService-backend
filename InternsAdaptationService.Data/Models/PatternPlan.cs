using InternsAdaptationService.Data.Models.Parents;

namespace InternsAdaptationService.Data.Models;

public class PatternPlan: BaseModel
{
    public required Guid MentorID { get; set; }

    public required string Title { get; set; }

    public virtual User Mentor { get; set; }
}
