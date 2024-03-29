using System.Linq.Expressions;
using InteractiveMapProject.Contracts.Repositories;
using InteractiveMapProject.Data.Db.Context;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbSet<TEntity> _entity;

    public Repository(ApplicationDbContext dbContext)
    {
        _entity = dbContext.Set<TEntity>();
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _entity.ToListAsync();
    }

    public async Task<TEntity?> GetAsync(Guid id)
    {
        return await _entity.FindAsync(id);
    }

    public void Add(TEntity entity)
    {
        _entity.Add(entity);
    }

    public void Update(TEntity entity)
    {
        _entity.Update(entity);
    }

    public void Remove(TEntity entity)
    {
        _entity.Remove(entity);
    }

    public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> e)
    {
        return _entity.FirstOrDefaultAsync(e);
    }
}
