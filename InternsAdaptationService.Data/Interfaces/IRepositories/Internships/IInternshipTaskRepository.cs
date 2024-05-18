using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Abstracts;

namespace InternsAdaptationService.Data.Interfaces.IRepositories.Internships;

public interface IInternshipTaskRepository : IBaseRepository<InternshipTaskEntity>
{
    public Task<IEnumerable<InternshipTaskEntity>> GetByInternIdAsync(Guid id);
}
