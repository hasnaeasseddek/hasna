using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Param.Application.IRepositories;
using Param.Infrastructure.Data;
using Param.Infrastructure.Repositories;

namespace Param.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        //database setup
        //string? databaseProvider = configuration["DatabaseProvider"];

        //if (databaseProvider == "MSSQL")
        //{
        string? con = configuration.GetConnectionString("mssql_con");
        //string con = @"Data Source=SAID\SQLEXPRESS;Initial Catalog=JobFactory_Prod_Param;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //services.AddDbContext<IBaseDbContext, BaseDbContext>(options => options.UseSqlServer(con));

        // DbContext service
        services.AddDbContext<BaseDbContext>(options =>
            options.UseSqlServer(con)
        ) ;

        //}
        //else if (databaseProvider == "MYSQL")
        //{
        //    string? con = configuration.GetConnectionString("mysql_con");
        //    services.AddDbContext<IBaseDbContext, MYSQL_DbContext>(options => options.UseMySql(con, ServerVersion.Parse("10.4.27-mariadb")));
        //}
        //else if (databaseProvider == "SQLITE")
        //{
        //    string? con = configuration.GetConnectionString("sqlite_con");
        //    services.AddDbContext<IBaseDbContext, SQLITE_DbContext>(options => options.UseSqlite(con));
        //}


        //dependency injection
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        return services;
    }
}