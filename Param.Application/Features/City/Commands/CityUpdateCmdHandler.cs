using MediatR;
using Param.Application.Interfaces;
using Param.Domain.DTOs;

namespace Param.Application.Features.City.Commands;

public class CityUpdateCmdHandler : IRequestHandler<CityUpdateCmd, CityGetDTO>
{
    private readonly IUnitOfService _service;
    public CityUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<CityGetDTO> Handle(CityUpdateCmd request, CancellationToken cancellationToken)
    {
        var cityPutDTO = new CityPutDTO(request.Id, request.Name);
        var city = await _service.CityService.UpdateAsync(cityPutDTO);
        return city;
    }
}