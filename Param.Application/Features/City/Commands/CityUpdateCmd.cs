using MediatR;
using Param.Domain.DTOs;

namespace Param.Application.Features.City.Commands;

public record CityUpdateCmd(int Id, string Name) : IRequest<CityGetDTO>;