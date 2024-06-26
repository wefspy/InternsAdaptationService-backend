﻿using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Patterns;
using InternsAdaptationService.Data.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories.Patterns;

public class PatternPlanRepository : BaseRepository<PatternPlanEntity>, IPatternPlanRepository
{
    public PatternPlanRepository(InternsAdaptationServiceDbContext db) : base(db)
    {
    }

    public async Task<IEnumerable<PatternPlanEntity>> GetByMentorIdAsync(Guid id)
    {
        return await _dbSet
            .Where(entity => entity.MentorId == id)
            .AsNoTracking()
            .ToArrayAsync();
    }

    public async Task<IEnumerable<PatternPlanEntity>> GetFromRoleAsync(string role)
    {
        return await _dbSet
            .Where(entity => entity.Mentor.Role == role)
            .AsNoTracking()
            .ToArrayAsync();
    }
}
