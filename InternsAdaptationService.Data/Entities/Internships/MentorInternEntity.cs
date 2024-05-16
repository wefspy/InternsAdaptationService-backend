using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Data.Entities.ParentEntities;

namespace InternsAdaptationService.Data.Entities.Internships;

public class MentorInternEntity : BaseEntity
{
    public required Guid MentorId { get; set; }

    public required Guid InternID { get; set; }

    public virtual required UserEntity Mentor { get; set; }

    public virtual required UserEntity Intern { get; set; }
}
