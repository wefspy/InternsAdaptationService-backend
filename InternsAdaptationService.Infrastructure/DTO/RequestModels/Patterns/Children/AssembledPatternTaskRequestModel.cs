using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;


namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Children;

public class AssembledPatternTaskRequestModel : IAssembledPatternTaskRequestModel
{
    public Guid PlanId { get; }

    public Guid TaskId { get; set; }

    public Guid MentorId { get; }

    public string Title { get; }

    public string Description { get; }

    public bool Reusable { get; }

    public int StartDate { get; }

    public int EndDate { get; }

    public AssembledPatternTaskRequestModel(Guid planId, Guid taskId, Guid mentorId, string title, string description, bool reusable, 
        int startDate, int endDate)
    {
        PlanId = planId;
        TaskId = taskId;
        MentorId = mentorId;
        Title = title;
        Description = description;
        Reusable = reusable;
        StartDate = startDate;
        EndDate = endDate;
    }
}
