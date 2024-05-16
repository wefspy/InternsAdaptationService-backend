﻿using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Interfaces.IRepositories.Parents;

namespace InternsAdaptationService.Data.Interfaces.IRepositories;

public interface IPatternPlanRepository : IBaseRepository<PatternPlanEntity>
{
    public Task<IEnumerable<PatternPlanEntity>> GetByMentorIdAsync(Guid id);
}
