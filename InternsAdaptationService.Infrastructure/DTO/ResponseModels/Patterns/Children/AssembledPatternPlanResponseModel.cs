using InternsAdaptationService.Infrastructure.DTO.Objects.Patterns.Children;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;
using System.Linq;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Children;

public class AssembledPatternPlanResponseModel : IAssembledPatternPlanResponseModel
{
    public Guid Id { get; }

    public Guid MentorId { get; }

    public string Title { get; }

    public IEnumerable<AssembledPatternTaskResponseModel> Tasks { get; }

    public AssembledPatternPlanResponseModel(Guid id, Guid mentorId, string title, IEnumerable<IAssembledPatternTaskResponseModel> tasks)
    {
        Id = id;
        MentorId = mentorId;
        Title = title;
        Tasks = tasks.Select(task => (AssembledPatternTaskResponseModel)task);
    }
}
