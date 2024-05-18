using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Internships;
using InternsAdaptationService.Infrastructure.Managers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Managers.Internships;

public class InternshipTaskManager : BaseManager<InternshipTaskEntity, InternshipTaskRequestModel, InternshipTaskResponseModel>,
    IInternshipTaskManager
{
    private readonly IInternshipTaskService _internshipTaskService;
    private readonly IInternshipTaskMapper _internshipTaskMapper;

    public InternshipTaskManager(IInternshipTaskService internshipTaskService, IInternshipTaskMapper internshipTaskMapper) :
        base(internshipTaskService, internshipTaskMapper)
    {
        _internshipTaskService = internshipTaskService;
        _internshipTaskMapper = internshipTaskMapper;
    }

    public async Task<IEnumerable<InternshipTaskResponseModel>> GetByInternIdAsync(Guid id)
    {
        var entities = await _internshipTaskService.GetByInternIdAsync(id);

        return entities
            .Select(entity => _internshipTaskMapper.ToResponse(entity));
    }
}
