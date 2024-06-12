using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Files;
using InternsAdaptationService.Data.Interfaces.IRepositories.Files;
using InternsAdaptationService.Data.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories.Files;

public class FileRepository : BaseRepository<FileEntity>, IFileRepository
{
    public FileRepository(InternsAdaptationServiceDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<FileEntity>> GetByTaskId(Guid id)
    {
        return await _dbSet
            .Where(entity => entity.TaskId == id)
            .AsNoTracking()
            .ToArrayAsync();
    }
}
