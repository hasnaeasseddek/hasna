using AutoMapper;
using Param.Application.Interfaces;
using Param.Application.IRepositories;

namespace Param.Application.Services;

internal class UnitOfService : IUnitOfService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public ICityService CityService { get; private set; }
    public UnitOfService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
        CityService = new CityService(_uow, _map);
    }
}
