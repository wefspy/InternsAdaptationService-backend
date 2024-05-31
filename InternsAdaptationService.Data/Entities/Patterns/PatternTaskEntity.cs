using InternsAdaptationService.Data.Entities.Abstracts;
using InternsAdaptationService.Data.Entities.Auth;

namespace InternsAdaptationService.Data.Entities.Patterns;

public class PatternTaskEntity : BaseEntity
{
    public required Guid MentorId { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public bool Reusable { get; set; }

    public virtual UserEntity Mentor { get; set; }

    public virtual IEnumerable<PatternPlanTaskEntity> PlanTasks { get; set; }

    public virtual IEnumerable<PatternSubtaskEntity> Subtasks { get; set; }
}
