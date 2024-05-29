using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Internships;

public interface IMentorInternService : IBaseService<MentorInternEntity>
{
    public Task<IEnumerable<MentorInternEntity>> GetByMentorIdAsync(Guid id);

    public Task<IEnumerable<MentorInternEntity>> GetByInternIdAsync(Guid id);

    public Task DeleteByMentorId(Guid id);

    public Task DeleteByInternId(Guid id);
}
