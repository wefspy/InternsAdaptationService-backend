using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories;
using InternsAdaptationService.Data.Repositories.Parents;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories;

public class PatternTaskRepository : BaseRepository<PatternTaskEntity>, IPatternTaskRepository
{
    public PatternTaskRepository(InternsAdaptationServiceDbContext db): base(db)
    {
    }   

    public async Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _db.PatternTasks
            .Where(patternTask => patternTask.MentorId == id)
            .ToListAsync();
    }
}
