using InternsAdaptationService.Data.Models.Parents;

namespace InternsAdaptationService.Data.Models;

public class PatternTask: BaseModel
{
    public required Guid MentorID { get; set; }
    
    public required string Title { get; set; }

    public required string Description { get; set; }

    public virtual required Mentor Mentor { get; set; }
}
