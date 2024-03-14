using Microsoft.Extensions.DependencyInjection;
using Param.Application.Interfaces;
using Param.Application.Services;
using System.Reflection;

namespace Param.Application;
public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //Auto mapper
        services.AddAutoMapper(typeof(Mapping.AutoMapperProfile));

        //MediatR
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        //Services Injection
        services.AddScoped<IUnitOfService, UnitOfService>();
        return services;
    }
}