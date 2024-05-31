using InternsAdaptationService.Data.Entities.Abstracts;
using InternsAdaptationService.Data.Entities.Auth;

namespace InternsAdaptationService.Data.Entities.Patterns;

public class PatternPlanEntity : BaseEntity
{
    public required Guid MentorId { get; set; }

    public required string Title { get; set; }

    public virtual UserEntity Mentor { get; set; }

    public virtual IEnumerable<PatternPlanTaskEntity> PlanTasks { get; set; }
}
