using Microsoft.EntityFrameworkCore;

namespace Param.Infrastructure.Data;

public class SQLITE_DbContext : BaseDbContext, IBaseDbContext
{
    public SQLITE_DbContext(DbContextOptions<SQLITE_DbContext> options) : base(options) { }
}