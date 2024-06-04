using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Abstracts;
using InternsAdaptationService.Data.Interfaces.IRepositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories.Abstracts;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    protected readonly InternsAdaptationServiceDbContext _db;
    protected readonly DbSet<TEntity> _dbSet;

    protected BaseRepository(InternsAdaptationServiceDbContext db)
    {
        _db = db;
        _dbSet = _db.Set<TEntity>();
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        var result = await _dbSet.AddAsync(entity);

        return result.Entity;
    }

    public virtual async Task CreateRangeAsync(IEnumerable<TEntity> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }

    public virtual Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);

        return Task.CompletedTask;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet
            .AsNoTracking()
            .ToListAsync();
    }

    public virtual async Task<TEntity> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);

        if (entity == null)
            throw new Exception("EntityNotFound");

        return entity;
    }

    public virtual Task DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);

        return Task.CompletedTask;
    }

    public virtual Task DeleteRangeAsync(IEnumerable<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);

        return Task.CompletedTask;
    }

    public async virtual Task SaveAsync()
    {
        await _db.SaveChangesAsync();
    }
}
