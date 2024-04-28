using InternsAdaptationService.Data.Models.Parents;

namespace InternsAdaptationService.Data.Models;

public class MentorIntern: BaseModel
{
    public required Guid MentorId { get; set; }

    public required Guid InternID { get; set; }

    public virtual required User Mentor { get; set; }

    public virtual required User Intern { get; set; }
}
