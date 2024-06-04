namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;

public interface IPatternPlanTaskRequestModel : IBaseRequestModel
{
    public Guid PlanId { get; }

    public Guid TaskId { get; set; }

    public int StartDate { get; }

    public int EndDate { get; }

}
