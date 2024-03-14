using Param.Application.IRepositories;
using Param.Infrastructure.Data;

namespace Param.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly IBaseDbContext _db;

    public ICityRepository CityRepository { get; private set; }
   
    public UnitOfWork(IBaseDbContext db)
    {
        _db = db;
        CityRepository = new CityRepository(_db);
        
    }


    public async Task<int> CompleteAsync()
        => await _db.SaveChangesAsync();
}
