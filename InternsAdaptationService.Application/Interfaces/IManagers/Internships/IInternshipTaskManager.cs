using InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Internships;

public interface IInternshipTaskManager : IBaseManager<IInternshipTaskRequestModel, IInternshipTaskResponseModel>
{
    public Task<IEnumerable<IInternshipTaskResponseModel>> GetByInternIdAsync(Guid id);
}
