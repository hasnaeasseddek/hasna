using MediatR;
using Param.Domain.DTOs;

namespace Param.Application.Features.City.Commands;

public record CityCreateCmd(string Name) : IRequest<CityGetDTO>;