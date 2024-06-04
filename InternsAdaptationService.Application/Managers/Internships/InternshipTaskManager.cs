using InternsAdaptationService.Application.Interfaces.IManagers.Internships;
using InternsAdaptationService.Application.Interfaces.IServices.Internships;
using InternsAdaptationService.Application.Managers.Abstracts;
using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;

namespace InternsAdaptationService.Application.Managers.Internships;

public class InternshipTaskManager : BaseManager<InternshipTaskEntity, IInternshipTaskRequestModel, IInternshipTaskResponseModel>,
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

    public async Task<IEnumerable<IInternshipTaskResponseModel>> GetByInternIdAsync(Guid id)
    {
        var entities = await _internshipTaskService.GetByInternIdAsync(id);

        return entities
            .Select(entity => _internshipTaskMapper.ToResponse(entity));
    }
}
