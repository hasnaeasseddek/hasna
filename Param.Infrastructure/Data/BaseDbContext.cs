using Microsoft.EntityFrameworkCore;
using Param.Domain.Entities;

namespace Param.Infrastructure.Data
{
    public class BaseDbContext : DbContext //, IBaseDbContext
    {
        public BaseDbContext() { }
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost\\sqlexpress;Database=JobFactory_Prod_Param;Trusted_Connection=True;Encrypt=False;");
            }
        }
        public DbSet<City> Cities { get; set; }
        public async Task<int> SaveChangesAsync()
                => await base.SaveChangesAsync();

    }
}
