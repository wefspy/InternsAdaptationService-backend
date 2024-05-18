using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Interfaces.IRepositories.Internships;
using InternsAdaptationService.Data.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories.Internships;

public class MentorInternRepository : BaseRepository<MentorInternEntity>, IMentorInternRepository
{
    public MentorInternRepository(InternsAdaptationServiceDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<MentorInternEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _dbSet
            .Where(entity => entity.MentorId == id)
            .AsNoTracking()
            .ToArrayAsync();
    }

    public async Task<IEnumerable<MentorInternEntity>> GetByInternIdAsync(Guid id)
    {
        return await _dbSet
            .Where(entity => entity.InternId == id)
            .AsNoTracking()
            .ToArrayAsync();
    }
}
