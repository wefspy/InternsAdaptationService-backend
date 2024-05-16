using InternsAdaptationService.Data.Entities.ParentEntities;

namespace InternsAdaptationService.Data.Entities.Patterns;

public class PatternSubtaskEntity : BaseEntity
{
    public required Guid TaskId { get; set; }

    public required string Title { get; set; }

    public virtual PatternTaskEntity PatternTask { get; set; }
}
