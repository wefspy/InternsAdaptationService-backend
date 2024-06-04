using InternsAdaptationService.Data.Context;
using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Data.Interfaces.IRepositories.User;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Repositories.User;

public class UserRepository : IUserRepository
{
    protected readonly InternsAdaptationServiceDbContext _db;
    protected readonly DbSet<UserEntity> _dbSet;

    public UserRepository(InternsAdaptationServiceDbContext db)
    {
        _db = db;
        _dbSet = _db.Set<UserEntity>();
    }

    public async Task<UserEntity> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);

        if (entity == null)
            throw new Exception("EntityNotFound");

        return entity;
    }

    public virtual async Task<IEnumerable<UserEntity>> GetAllAsync()
    {
        return await _dbSet
            .AsNoTracking()
            .ToListAsync();
    }
}
