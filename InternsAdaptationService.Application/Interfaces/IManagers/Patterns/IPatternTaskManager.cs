using InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Patterns;

public interface IPatternTaskManager : IBaseManager<IPatternTaskRequestModel, IPatternTaskResponseModel>
{
    public Task<IEnumerable<IPatternTaskResponseModel>> GetByMentorIdAsync(Guid id);
}
