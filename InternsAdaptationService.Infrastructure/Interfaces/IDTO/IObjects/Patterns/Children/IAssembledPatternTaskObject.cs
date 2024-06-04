using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels;

namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IObjects.Patterns.Children;

public interface IAssembledPatternTaskObject : IBaseRequestModel
{
    public Guid Id { get; }

    public string Title { get; }

    public string Description { get; }

    public bool Reusable { get; }

    public int StartDate { get; }

    public int EndDate { get; }

}
