using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Internships;

public interface IMentorInternManager : IBaseManager<MentorInternRequestModel, MentorInternResponseModel>
{
    public Task<IEnumerable<MentorInternResponseModel>> GetByMentorIdAsync(Guid id);

    public Task<IEnumerable<UserResponseModel>> GetInternsByMentorId(Guid id);

    public Task<IEnumerable<MentorInternResponseModel>> GetByInternIdAsync(Guid id);

    public Task<IEnumerable<UserResponseModel>> GetMentorsByInternId(Guid id);

    public Task DeleteByMentorId(Guid id);

    public Task DeleteByInternId(Guid id);
}
