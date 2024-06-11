using InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Patterns;

public interface IPatternPlanManager : IBaseManager<IPatternPlanRequestModel, IPatternPlanResponseModel>
{
    public Task<IEnumerable<IPatternPlanResponseModel>> GetByMentorIdAsync(Guid id);

    public Task<IEnumerable<IPatternPlanResponseModel>> GetFromRoleAsync(string role);
}

