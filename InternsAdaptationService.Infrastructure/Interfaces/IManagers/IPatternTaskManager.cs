using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.PatternTask;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.PatternTask;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers;

public interface IPatternTaskManager
{
    public Task<PatternTaskResponseModel> CreateAsync(PatternTaskRequestModel request);

    public Task UpdateAsync(Guid id, PatternTaskRequestModel request);

    public Task<IEnumerable<PatternTaskResponseModel>> GetAllAsync();

    public Task<PatternTaskResponseModel> GetByIdAsync(Guid id);

    public Task<IEnumerable<PatternTaskResponseModel>> GetByMentorIdAsync(Guid id);

    public Task DeleteAsync(Guid id);
}
