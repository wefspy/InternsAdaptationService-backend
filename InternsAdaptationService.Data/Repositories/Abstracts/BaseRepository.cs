using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Parents;
using InternsAdaptationService.Data.Interfaces.IRepositories.Parents;
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

        await _db.SaveChangesAsync();

        return result.Entity;
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);

        await _db.SaveChangesAsync();
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

    public virtual async Task DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);

        await _db.SaveChangesAsync();
    }
}
