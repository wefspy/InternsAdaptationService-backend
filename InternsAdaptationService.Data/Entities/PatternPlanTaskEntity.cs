using InternsAdaptationService.Data.Entities.ParentEntities;

namespace InternsAdaptationService.Data.Entities;

public class PatternPlanTaskEntity: BaseEntity
{
    public required Guid PlanId { get; set; }

    public required Guid TaskId { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime Deadline { get; set; }

    public virtual PatternPlanEntity PatternPlan { get; set; }

    public virtual PatternTaskEntity PatternTask { get; set; }
}
