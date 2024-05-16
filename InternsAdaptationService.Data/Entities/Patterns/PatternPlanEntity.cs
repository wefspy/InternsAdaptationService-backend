using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Data.Entities.ParentEntities;

namespace InternsAdaptationService.Data.Entities.Patterns;

public class PatternPlanEntity : BaseEntity
{
    public required Guid MentorId { get; set; }

    public required string Title { get; set; }

    public virtual UserEntity Mentor { get; set; }
}
