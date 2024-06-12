using InternsAdaptationService.Data.Entities.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Files;

namespace InternsAdaptationService.Application.Interfaces.IServices.Files;

public interface IFileService
{
    public Task<FileEntity> CreateAsync(IFileRequestModel request);

    public IEnumerable<FileEntity> CreateRangeAsync(IEnumerable<IFileRequestModel> requests);

    public Task<IEnumerable<FileEntity>> GetAllAsync();

    public Task<FileEntity> GetByIdAsync(Guid id);

    public Task<IEnumerable<FileEntity>> GetByTaskId(Guid id);

    public Task DeleteAsync(Guid id);

    public Task DeleteRangeAsync(IEnumerable<Guid> ids);

    public Task SaveAsync();
}
