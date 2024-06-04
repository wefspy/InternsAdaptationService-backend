using InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Internships;

public interface IMentorInternManager : IBaseManager<IMentorInternRequestModel, IMentorInternResponseModel>
{
    public Task<IEnumerable<IMentorInternResponseModel>> GetByMentorIdAsync(Guid id);

    public Task<IEnumerable<IUserResponseModel>> GetInternsByMentorId(Guid id);

    public Task<IEnumerable<IMentorInternResponseModel>> GetByInternIdAsync(Guid id);

    public Task<IEnumerable<IUserResponseModel>> GetMentorsByInternId(Guid id);

    public Task DeleteByMentorId(Guid id);

    public Task DeleteByInternId(Guid id);
}
