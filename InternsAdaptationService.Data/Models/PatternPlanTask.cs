using InternsAdaptationService.Data.Models.Parents;

namespace InternsAdaptationService.Data.Models;

public class PatternPlanTask: BaseModel
{
    public required Guid PlanID { get; set; }

    public required Guid TaskID { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime Deadline { get; set; }

    public virtual PatternPlan PatternPlan { get; set; }

    public virtual PatternTask PatternTask { get; set; }
}
