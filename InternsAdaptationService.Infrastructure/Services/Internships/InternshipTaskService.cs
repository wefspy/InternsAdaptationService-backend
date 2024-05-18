using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Internships;
using InternsAdaptationService.Infrastructure.Services.Abstracts;

namespace InternsAdaptationService.Infrastructure.Services.Internships;

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
