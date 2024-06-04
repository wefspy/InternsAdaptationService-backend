using InternsAdaptationService.Application.Interfaces.IServices.Internships;
using InternsAdaptationService.Application.Services.Abstracts;
using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Internships;

namespace InternsAdaptationService.Application.Services.Internships;

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

    public async Task DeleteByMentorId(Guid id)
    {
        var entities = await GetByMentorIdAsync(id);

        await _mentorInternRepository.DeleteRangeAsync(entities);
    }

    public async Task DeleteByInternId(Guid id)
    {
        var entities = await GetByInternIdAsync(id);

        await _mentorInternRepository.DeleteRangeAsync(entities);
    }
}
