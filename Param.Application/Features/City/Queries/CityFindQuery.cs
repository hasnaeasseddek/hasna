using MediatR;
using Param.Domain.DTOs;

namespace Param.Application.Features.City.Queries;

public record CityFindQuery(int Id) : IRequest<CityGetDTO>;