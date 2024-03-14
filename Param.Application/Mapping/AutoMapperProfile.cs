using AutoMapper;
using Param.Domain.DTOs;
using Param.Domain.Entities;


namespace Param.Application.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        //City Mapping
        CreateMap<City, CityGetDTO>();
        CreateMap<CityPostDTO, City>();
        CreateMap<CityPutDTO, City>();

    }
}
