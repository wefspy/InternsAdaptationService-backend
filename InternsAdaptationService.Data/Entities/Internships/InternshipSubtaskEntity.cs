using InternsAdaptationService.Data.Entities.Abstracts;

namespace InternsAdaptationService.Data.Entities.Internships;

public class InternshipSubtaskEntity : BaseEntity
{
    public required Guid TaskId { get; set; }

    public required string Title { get; set; }

    public required bool isActive { get; set; }

    public virtual InternshipTaskEntity InternshipTask { get; set; }
}
