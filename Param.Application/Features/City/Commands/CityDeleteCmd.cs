using MediatR;

namespace Param.Application.Features.City.Commands;

public record CityDeleteCmd(int Id) : IRequest<bool>;