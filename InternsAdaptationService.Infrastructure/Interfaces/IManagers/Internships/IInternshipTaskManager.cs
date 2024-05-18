using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Internships;

public interface IInternshipTaskManager : IBaseManager<InternshipTaskRequestModel, InternshipTaskResponseModel>
{
    public Task<IEnumerable<InternshipTaskResponseModel>> GetByInternIdAsync(Guid id);
}
