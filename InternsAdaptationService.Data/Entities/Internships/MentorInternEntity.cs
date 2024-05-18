using InternsAdaptationService.Data.Entities.Abstracts;
using InternsAdaptationService.Data.Entities.Auth;

namespace InternsAdaptationService.Data.Entities.Internships;

public class MentorInternEntity : BaseEntity
{
    public required Guid MentorId { get; set; }

    public required Guid InternId { get; set; }

    public virtual UserEntity Mentor { get; set; }

    public virtual UserEntity Intern { get; set; }
}
