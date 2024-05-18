using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Internships;
using InternsAdaptationService.Infrastructure.Services.Abstracts;

namespace InternsAdaptationService.Infrastructure.Services.Internships;

public class MentorInternService : BaseService<MentorInternEntity>, IMentorInternService
{
    private readonly IMentorInternRepository _mentorInternRepository;

    public MentorInternService(IMentorInternRepository mentorInternRepository) : base(mentorInternRepository)
    {
        _mentorInternRepository = mentorInternRepository;
    }

    public async Task<IEnumerable<MentorInternEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _mentorInternRepository.GetByMentorIdAsync(id);
    }

    public async Task<IEnumerable<MentorInternEntity>> GetByInternIdAsync(Guid id)
    {
        return await _mentorInternRepository.GetByInternIdAsync(id);
    }
}
