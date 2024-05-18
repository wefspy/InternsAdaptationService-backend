using InternsAdaptationService.Data.Entities.Abstracts;

namespace InternsAdaptationService.Data.Entities.Patterns;

public class PatternPlanTaskEntity : BaseEntity
{
    public required Guid PlanId { get; set; }

    public required Guid TaskId { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime EndDate { get; set; }

    public virtual PatternPlanEntity PatternPlan { get; set; }

    public virtual PatternTaskEntity PatternTask { get; set; }
}
