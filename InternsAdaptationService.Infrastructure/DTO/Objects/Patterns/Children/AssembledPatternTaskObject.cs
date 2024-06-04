using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IObjects.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.DTO.Objects.Patterns.Children;

public class AssembledPatternTaskObject : IAssembledPatternTaskObject
{
    public Guid Id { get; }

    public string Title { get; }

    public string Description { get; }

    public bool Reusable { get; }

    public int StartDate { get; }

    public int EndDate { get; }

    public AssembledPatternTaskObject(Guid id, string title, string description, bool reusable, int startDate, int endDate)
    {
        Id = id;
        Title = title;
        Description = description;
        Reusable = reusable;
        StartDate = startDate;
        EndDate = endDate;
    }
}
