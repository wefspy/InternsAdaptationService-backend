using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Internships;

public interface IMentorInternManager : IBaseManager<MentorInternRequestModel, MentorInternResponseModel>
{
    public Task<IEnumerable<MentorInternResponseModel>> GetByMentorIdAsync(Guid id);

    public Task<IEnumerable<MentorInternResponseModel>> GetByInternIdAsync(Guid id);
}
