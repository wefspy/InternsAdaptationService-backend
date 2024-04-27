using InternsAdaptationService.Data.Models.Parents;

namespace InternsAdaptationService.Data.Models;

public class PatternSubtask: BaseModel
{
    public required Guid TaskID { get; set; }

    public required string Title { get; set; }

    public virtual PatternTask PatternTask { get; set; }
}
