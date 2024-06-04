using InternsAdaptationService.Application.Interfaces.IManagers.Internships;
using InternsAdaptationService.Application.Interfaces.IManagers.User;
using InternsAdaptationService.Application.Interfaces.IServices.Internships;
using InternsAdaptationService.Application.Managers.Abstracts;
using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;

namespace InternsAdaptationService.Application.Managers.Internships;

public class MentorInternManager : BaseManager<MentorInternEntity, IMentorInternRequestModel, IMentorInternResponseModel>,
    IMentorInternManager
{
    private readonly IMentorInternService _mentorInternService;
    private readonly IMentorInternMapper _mentorInternMapper;
    private readonly IUserManager _userManager;

    public MentorInternManager(IMentorInternService mentorInternService, IMentorInternMapper mentorInternMapper,
        IUserManager userManager) : base(mentorInternService, mentorInternMapper)
    {
        _mentorInternService = mentorInternService;
        _mentorInternMapper = mentorInternMapper;
        _userManager = userManager;
    }

    public async Task<IEnumerable<IMentorInternResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _mentorInternService.GetByMentorIdAsync(id);

        return entities
            .Select(entity => _mentorInternMapper.ToResponse(entity));
    }

    public async Task<IEnumerable<IUserResponseModel>> GetInternsByMentorId(Guid id)
    {
        var mentorInterns = await GetByMentorIdAsync(id);

        return mentorInterns
            .Select(mentorIntern => _userManager.GetByIdAsync(mentorIntern.InternId).Result);
    }

    public async Task<IEnumerable<IMentorInternResponseModel>> GetByInternIdAsync(Guid id)
    {
        var entities = await _mentorInternService.GetByInternIdAsync(id);

        return entities
            .Select(entity => _mentorInternMapper.ToResponse(entity));
    }

    public async Task<IEnumerable<IUserResponseModel>> GetMentorsByInternId(Guid id)
    {
        var mentorInterns = await GetByMentorIdAsync(id);

        return mentorInterns
            .Select(mentorIntern => _userManager.GetByIdAsync(mentorIntern.MentorId).Result);
    }

    public async Task DeleteByMentorId(Guid id)
    {
        await _mentorInternService.DeleteByMentorId(id);

        await _mentorInternService.SaveAsync();
    }

    public async Task DeleteByInternId(Guid id)
    {
        await _mentorInternService.DeleteByInternId(id);

        await _mentorInternService.SaveAsync();
    }
}

