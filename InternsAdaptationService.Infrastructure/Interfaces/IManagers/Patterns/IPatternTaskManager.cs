using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.PatternTask;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;

public interface IPatternTaskManager : IBaseManager<PatternTaskRequestModel, PatternTaskResponseModel>
{
    public Task<IEnumerable<PatternTaskResponseModel>> GetByMentorIdAsync(Guid id);
}
