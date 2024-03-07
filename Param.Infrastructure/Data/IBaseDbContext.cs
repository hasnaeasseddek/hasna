
using Microsoft.EntityFrameworkCore;
using Param.Domain.Entities;

namespace Param.Infrastructure.Data
{
    public interface IBaseDbContext
    {
        DbSet<City> Cities { get; set; }

    }
}
