using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;
using InternsAdaptationService.Data.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories.Patterns;

public class PatternTaskRepository : BaseRepository<PatternTaskEntity>, IPatternTaskRepository
{
    public PatternTaskRepository(InternsAdaptationServiceDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _dbSet
            .Where(entity => entity.MentorId == id)
            .ToArrayAsync();
    }
}
