using InternsAdaptationService.Data.Entities.Files;
using InternsAdaptationService.Data.Interfaces.IRepositories.Abstracts;

namespace InternsAdaptationService.Data.Interfaces.IRepositories.Files;

public interface IFileRepository : IBaseRepository<FileEntity>
{
    public Task<IEnumerable<FileEntity>> GetByTaskId(Guid id);
}
