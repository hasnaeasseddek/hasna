using MediatR;
using Param.Domain.DTOs;

namespace Param.Application.Features.City.Queries;

public record CityFindAllQuery : IRequest<IEnumerable<CityGetDTO>>;