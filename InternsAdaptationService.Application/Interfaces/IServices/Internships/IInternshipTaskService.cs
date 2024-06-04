using InternsAdaptationService.Application.Interfaces.IServices.Abstracts;
using InternsAdaptationService.Data.Entities.Internships;

namespace InternsAdaptationService.Application.Interfaces.IServices.Internships;

public interface IInternshipTaskService : IBaseService<InternshipTaskEntity>
{
    public Task<IEnumerable<InternshipTaskEntity>> GetByInternIdAsync(Guid id);
}

