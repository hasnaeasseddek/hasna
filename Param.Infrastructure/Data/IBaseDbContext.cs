using Param.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Param.Infrastructure.Data;

public interface IBaseDbContext
{
    DbSet<City> Cities { get; set; }
   
    DbSet<T> Set<T>() where T : class;

    Task<int> SaveChangesAsync();
}