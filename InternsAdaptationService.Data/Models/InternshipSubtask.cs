using InternsAdaptationService.Data.Models.Parents;

namespace InternsAdaptationService.Data.Models;

public class InternshipSubtask: BaseModel
{
    public required Guid TaskID { get; set; }

    public required string Title { get; set; }

    public required bool isActive { get; set; }

    public virtual InternshipTask InternshipTask { get; set; }
}
