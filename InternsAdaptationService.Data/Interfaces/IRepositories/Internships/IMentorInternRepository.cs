using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Abstracts;

namespace InternsAdaptationService.Data.Interfaces.IRepositories.Internships;

public interface IMentorInternRepository : IBaseRepository<MentorInternEntity>
{
    public Task<IEnumerable<MentorInternEntity>> GetByMentorIdAsync(Guid id);

    public Task<IEnumerable<MentorInternEntity>> GetByInternIdAsync(Guid id);
}
