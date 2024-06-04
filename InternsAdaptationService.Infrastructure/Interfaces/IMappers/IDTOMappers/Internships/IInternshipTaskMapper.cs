using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;

public interface IInternshipTaskMapper : IBaseDTOMapper<InternshipTaskEntity, IInternshipTaskRequestModel, IInternshipTaskResponseModel>
{
    public InternshipTaskEntity ToNewEntity(Guid internId, PatternPlanTaskEntity planTask, PatternTaskEntity task);
}
