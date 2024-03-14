using MediatR;
using Param.Application.Interfaces;
using Param.Domain.DTOs;

namespace Param.Application.Features.City.Commands;

public class CityCreateCmdHandler : IRequestHandler<CityCreateCmd, CityGetDTO>
{
    private readonly IUnitOfService _service;
    public CityCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<CityGetDTO> Handle(CityCreateCmd request, CancellationToken cancellationToken)
    {
        var cityPostDTO = new CityPostDTO(request.Name);
        var city = await _service.CityService.CreateAsync(cityPostDTO);
        return city;
    }
}