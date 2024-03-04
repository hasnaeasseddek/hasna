using Freelance.Application.Persistence.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Freelance.Infrastructure.Persistence.Repositories;

public class CandidatAggregatRepository<T> : IGenericRepository<T> where T : class
{

    private readonly ApplicationDbContext _db;
    private DbSet<T> _table;


    public CandidatAggregatRepository(ApplicationDbContext db)
    {
        _db = db;
        _table = _db.Set<T>();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<T> PostAsync(T entity)
    {
        await _table.AddAsync(entity);
        await _db.SaveChangesAsync();
        return entity;
    }

    public Task<IEnumerable<T>> PostRangeAsync(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task<T> PutAsync(int id, T entity)
    {
        throw new NotImplementedException();
    }
}
