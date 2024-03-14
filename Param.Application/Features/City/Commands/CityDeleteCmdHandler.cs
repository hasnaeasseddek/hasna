using MediatR;
using Param.Application.Interfaces;

namespace Param.Application.Features.City.Commands;

public class CityDeleteCmdHandler : IRequestHandler<CityDeleteCmd, bool>
{
    private readonly IUnitOfService _service;
    public CityDeleteCmdHandler(IUnitOfService service) => _service = service;




    public async Task<bool> Handle(CityDeleteCmd request, CancellationToken cancellationToken)
    {
        bool success = await _service.CityService.DeleteAsync(request.Id);
        return success;
    }
}