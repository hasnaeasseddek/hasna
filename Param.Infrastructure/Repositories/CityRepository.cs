using Param.Application.IRepositories;
using Param.Domain.Entities;
using Param.Infrastructure.Data;

namespace Param.Infrastructure.Repositories;
public class CityRepository : Repository<City>, ICityRepository
{
    public CityRepository(IBaseDbContext db) : base(db) { }
}
