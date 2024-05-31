using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Plan;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns.Task;

public class AssembledPatternTaskMapper : IAssembledPatternTaskMapper
{
    public AssembledPatternTaskResponseModel ToResponse(PatternPlanTaskResponseModel planTask, PatternTaskResponseModel task)
    {
        return new AssembledPatternTaskResponseModel(task.Id, task.MentorId, planTask.PlanId, task.Title, task.Description,
            planTask.StartDate, planTask.EndDate, task.Reusable);
    }

    public AssembledPatternTaskRequestModel ToRequest(BodyAssembledPatternTaskRequestModel task, PatternPlanResponseModel plan)
    {
        return new AssembledPatternTaskResponseModel(task.Id, plan.MentorId, plan.Id, task.Title, task.Description, 
            task.StartDate, task.EndDate, task.Reusable);
    }

    public PatternTaskRequestModel ToPatternTaskRequestModel(AssembledPatternTaskRequestModel request)
    {
        return new PatternTaskRequestModel(request.MentorId, request.Title, request.Description, request.Reusable);
    }

    public PatternPlanTaskRequestModel ToPatternPlanTaskRequestModel(Guid taskId, AssembledPatternTaskRequestModel request)
    {
        return new PatternPlanTaskRequestModel(request.PlanId, taskId, request.StartDate, request.EndDate);
    }
}
