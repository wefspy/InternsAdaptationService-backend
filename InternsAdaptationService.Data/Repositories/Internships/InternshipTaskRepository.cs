using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Internships;
using InternsAdaptationService.Data.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories.Internships;

public class InternshipTaskRepository : BaseRepository<InternshipTaskEntity>, IInternshipTaskRepository
{
    public InternshipTaskRepository(InternsAdaptationServiceDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<InternshipTaskEntity>> GetByInternIdAsync(Guid id)
    {
        return await _dbSet
            .Where(entity => entity.InternId == id)
            .AsNoTracking()
            .ToArrayAsync();
    }
}
