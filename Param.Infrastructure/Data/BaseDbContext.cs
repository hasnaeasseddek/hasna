using Microsoft.EntityFrameworkCore;
using Param.Domain.Entities;

namespace Param.Infrastructure.Data
{
    public class BaseDbContext : DbContext, IBaseDbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options) { }

        public DbSet<City> Cities { get; set; }
    }
}
