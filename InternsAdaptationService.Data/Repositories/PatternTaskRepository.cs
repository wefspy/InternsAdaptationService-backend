using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Data.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories;

public class PatternTaskRepository : IPatternTaskRepository
{
    private readonly InternsAdaptationServiceDbContext _db;

    public PatternTaskRepository(InternsAdaptationServiceDbContext db)
    {
        _db = db;
    }

    public async Task<PatternTaskEntity> CreateAsync(PatternTaskEntity request)
    {
        var record = await _db.PatternTasks.AddAsync(request);

        await _db.SaveChangesAsync();

        return record.Entity;
    }

    public async Task UpdateAsync(PatternTaskEntity request)
    {
        _db.PatternTasks.Update(request);

        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<PatternTaskEntity>> GetAllAsync()
    {
        return await _db.PatternTasks
            .AsNoTracking()
            .ToArrayAsync();
    }

    public async Task<PatternTaskEntity> GetByIdAsync(Guid id)
    {
        var entity = await _db.PatternTasks
            .AsNoTracking()
            .FirstOrDefaultAsync(patternTask => patternTask.Id == id);

        if (entity == null)
            throw new Exception("EntityNotFound");

        return entity;
    }

    public async Task<IEnumerable<PatternTaskEntity>> GetByMentorIdAsync(Guid mentorId)
    {
        return await _db.PatternTasks
            .Where(patternTask => patternTask.MentorId == mentorId)
            .ToListAsync();
    }

    public async Task DeleteAsync(PatternTaskEntity request)
    {
        _db.PatternTasks.Remove(request);

        await _db.SaveChangesAsync();
    }
}
