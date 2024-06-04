using InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Patterns;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Patterns;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Patterns;

public interface IPatternPlanManager : IBaseManager<IPatternPlanRequestModel, IPatternPlanResponseModel>
{
    public Task<IEnumerable<IPatternPlanResponseModel>> GetByMentorIdAsync(Guid id);
}

