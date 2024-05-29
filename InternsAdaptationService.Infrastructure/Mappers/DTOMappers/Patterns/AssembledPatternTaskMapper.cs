using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Patterns;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Patterns;

public class AssembledPatternTaskMapper : IAssembledPatternTaskMapper
{
    public AssembledPatternTaskResponseModel ToResponse(PatternPlanTaskResponseModel planTask, PatternTaskResponseModel task)
    {
        return new AssembledPatternTaskResponseModel(task.Id, task.MentorId, planTask.PlanId, task.Title, task.Description, 
            planTask.StartDate, planTask.EndDate, task.Reusable);
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
