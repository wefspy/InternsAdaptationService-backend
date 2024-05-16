using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories;
using InternsAdaptationService.Data.Repositories.Parents;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories;

public class PatternPlanRepository : BaseRepository<PatternPlanEntity>,  IPatternPlanRepository
{
    public PatternPlanRepository(InternsAdaptationServiceDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<PatternPlanEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _db.PatternPlans
            .Where(patternTask => patternTask.MentorId == id)
            .ToListAsync();
    }
}
