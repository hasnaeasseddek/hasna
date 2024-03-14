using AutoMapper;
using Param.Application.Interfaces;
using Param.Application.IRepositories;
using Param.Domain.DTOs;
using Param.Domain.Entities;

namespace Param.Application.Services;

public class CityService : ICityService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public CityService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;
    }

    public async Task<CityGetDTO> FindAsync(int id)
    {
        var city = await _uow.CityRepository.GetAsync(id);

        if (city is null) return null;

        return _map.Map<CityGetDTO>(city);
    }
    public async Task<IEnumerable<CityGetDTO>> FindAllAsync()
    {
        var cities = await _uow.CityRepository.GetAllAsync();

        if (cities is null) return null;

        return _map.Map<IEnumerable<CityGetDTO>>(cities);
    }
    public async Task<CityGetDTO> CreateAsync(CityPostDTO cityPostDTO)
    {
        var city = _map.Map<City>(cityPostDTO);
        if (!await _uow.CityRepository.PostAsync(city))
            return null;

        await _uow.CompleteAsync();
        return _map.Map<CityGetDTO>(city);
    }
    public async Task<CityGetDTO> UpdateAsync(CityPutDTO cityPutDTO)
    {
        var city = _map.Map<City>(cityPutDTO);
        var updatedCity = await _uow.CityRepository.PutAsync(city.Id, city);

        await _uow.CompleteAsync();
        return _map.Map<CityGetDTO>(updatedCity);
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var success = await _uow.CityRepository.RemoveAsync(id);
        await _uow.CompleteAsync();
        return success;
    }
}