using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Internships;

public interface IInternshipTaskService : IBaseService<InternshipTaskEntity>
{
    public Task<IEnumerable<InternshipTaskEntity>> GetByInternIdAsync(Guid id);
}
