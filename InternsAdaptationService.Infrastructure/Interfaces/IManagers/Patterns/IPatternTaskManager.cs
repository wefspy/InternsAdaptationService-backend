using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Patterns;

public interface IPatternTaskManager : IBaseManager<PatternTaskRequestModel, PatternTaskResponseModel>
{
    public Task<IEnumerable<PatternTaskResponseModel>> GetByMentorIdAsync(Guid id);

    public Task<AssembledPatternTaskResponseModel> CreateAssembledAsync(AssembledPatternTaskRequestModel request);

    public IEnumerable<AssembledPatternTaskResponseModel> CreateRangeAssembled(IEnumerable<AssembledPatternTaskRequestModel> requests);
}
