using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;
using InternsAdaptationService.Data.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories.Patterns;

public class PatternPlanTaskRepository : BaseRepository<PatternPlanTaskEntity>, IPatternPlanTaskRepository
{
    public PatternPlanTaskRepository(InternsAdaptationServiceDbContext db) : base(db)
    {
    }

    public async Task CreateRangeAsync(PatternPlanTaskEntity[] entities)
    {
        await _dbSet.AddRangeAsync(entities);

        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<PatternPlanTaskEntity>> GetByPlanIdAsync(Guid id)
    {
        return await _dbSet
            .Where(entity => entity.PlanId == id)
            .AsNoTracking()
            .ToArrayAsync();
    }
}
