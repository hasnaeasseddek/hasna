using MediatR;
using Param.Application.Interfaces;
using Param.Domain.DTOs;

namespace Param.Application.Features.City.Queries;

public class CityFindAllQueryHandler : IRequestHandler<CityFindAllQuery, IEnumerable<CityGetDTO>>
{
    private readonly IUnitOfService _service;
    public CityFindAllQueryHandler(IUnitOfService service) => _service = service;




    public async Task<IEnumerable<CityGetDTO>> Handle(CityFindAllQuery request, CancellationToken cancellationToken)
    {
        var cities = await _service.CityService.FindAllAsync();
        return cities;
    }
}