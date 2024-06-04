using InternsAdaptationService.Application.Interfaces.IServices.Internships;
using InternsAdaptationService.Application.Services.Abstracts;
using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Internships;


namespace InternsAdaptationService.Application.Services.Internships;

public class InternshipTaskService : BaseService<InternshipTaskEntity>, IInternshipTaskService
{
    private readonly IInternshipTaskRepository _internshipTaskRepository;

    public InternshipTaskService(IInternshipTaskRepository internshipTaskRepository)
        : base(internshipTaskRepository)
    {
        _internshipTaskRepository = internshipTaskRepository;
    }

    public async Task<IEnumerable<InternshipTaskEntity>> GetByInternIdAsync(Guid id)
    {
        return await _internshipTaskRepository.GetByInternIdAsync(id);
    }
}
