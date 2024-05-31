using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PlanTask;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;

public interface IInternshipTaskMapper : IBaseDTOMapper<InternshipTaskEntity, InternshipTaskRequestModel, InternshipTaskResponseModel>
{
    public InternshipTaskRequestModel ToRequest(Guid internId, PatternPlanTaskRequestModel planTask, PatternTaskRequestModel task);
}
