using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Files;
using Microsoft.AspNetCore.Http;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Files;

public interface IFileManager
{
    public Task<IFileResponseModel> CreateAsync(Guid taskId, IFormFile file);

    public Task<IEnumerable<IFileResponseModel>> CreateRangeAsync(Guid taskId, IEnumerable<IFormFile> files);

    public Task<IEnumerable<IFileResponseModel>> GetAllAsync();

    public Task<IFileResponseModel> GetByIdAsync(Guid id);

    public Task<IEnumerable<IFileResponseModel>> GetByTaskId(Guid id);

    public Task DeleteAsync(Guid id);

    public Task DeleteRangeAsync(IEnumerable<Guid> ids);
}
