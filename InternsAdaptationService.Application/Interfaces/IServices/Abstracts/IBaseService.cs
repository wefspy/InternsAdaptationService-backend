﻿using InternsAdaptationService.Data.Interfaces.IEntities.Parents;


namespace InternsAdaptationService.Application.Interfaces.IServices.Abstracts;

public interface IBaseService<TEntity>
    where TEntity : IBaseEntity
{
    public Task<TEntity> CreateAsync(TEntity entity);

    public Task CreateRangeAsync(IEnumerable<TEntity> entities);

    public Task UpdateAsync(TEntity entity);

    public Task<IEnumerable<TEntity>> GetAllAsync();

    public Task<TEntity> GetByIdAsync(Guid id);

    public Task DeleteAsync(Guid id);

    public Task DeleteRangeAsync(IEnumerable<Guid> ids);

    public Task SaveAsync();
}
