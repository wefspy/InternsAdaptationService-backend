using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;

public class BodyAssembledPatternTaskRequestModel : IBaseRequestModel
{
    public Guid Id { get; } = Guid.Empty;

    public string Title { get; }

    public string Description { get; }

    public bool Reusable { get; }

    public int StartDate { get; }

    public int EndDate { get; }

    public BodyAssembledPatternTaskRequestModel(Guid id, string title, string description, bool reusable, 
        int startDate, int endDate)
    {
        Id = id;
        Title = title;
        Description = description;
        Reusable = reusable;
        StartDate = startDate;
        EndDate = endDate;
    }
}
