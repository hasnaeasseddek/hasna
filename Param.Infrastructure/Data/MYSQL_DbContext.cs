using Microsoft.EntityFrameworkCore;

namespace Param.Infrastructure.Data;

public class MYSQL_DbContext : BaseDbContext, IBaseDbContext
{
    public MYSQL_DbContext(DbContextOptions<MYSQL_DbContext> options) : base(options) { }
}