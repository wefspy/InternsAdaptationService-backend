using InternsAdaptationService.Data.Entities.ParentEntities;

namespace InternsAdaptationService.Data.Entities;

public class PatternTaskEntity: BaseEntity
{
    public required Guid MentorId { get; set; }
    
    public required string Title { get; set; }

    public required string Description { get; set; }

    public virtual required UserEntity Mentor { get; set; }
}
