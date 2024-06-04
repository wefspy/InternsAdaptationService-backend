using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IObjects.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns.Children;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns.Children;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns.Children;

public class AssembledPatternTaskMapper : IAssembledPatternTaskMapper
{
    public IAssembledPatternTaskResponseModel ToResponse(PatternPlanTaskEntity planTask, PatternTaskEntity task)
    {
        return new AssembledPatternTaskResponseModel(planTask.PlanId, task.Id, task.MentorId, task.Title, task.Description,
            task.Reusable, planTask.StartDate, planTask.EndDate);
    }

    public IAssembledPatternTaskRequestModel ToRequest(IAssembledPatternTaskObject task, PatternPlanEntity plan)
    {
        return new AssembledPatternTaskResponseModel(plan.Id, task.Id, plan.MentorId, task.Title, task.Description,
            task.Reusable, task.StartDate, task.EndDate);
    }
}
