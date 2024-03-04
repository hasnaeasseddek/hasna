using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.DomaineExpertise;
using Freelance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.DomaineExpertiseService;

public class DomaineExpertiseService : IDomaineExpertiseService
{
    private readonly IGenericRepository<DomaineExpertise> _consultaionProfileService;
    private readonly IMapper _mapper;

    public DomaineExpertiseService(IGenericRepository<DomaineExpertise> experieceService, IMapper mapper)
    {
        _consultaionProfileService = experieceService;
        _mapper = mapper;
    }

    public async Task<DomaineExpertiseDTO> CreateAsync(DomaineExpertiseCreateDTO entity)
    {
        var consultaionProfil = _mapper.Map<DomaineExpertise>(entity);
        var createdExperience = await _consultaionProfileService.PostAsync(consultaionProfil);
        return _mapper.Map<DomaineExpertiseDTO>(createdExperience);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetenceDm = await _consultaionProfileService.GetAsync(id);
        if (existingcompetenceDm == null)
            return;
        await _consultaionProfileService.DeleteAsync(id);
    }

    public async Task<List<DomaineExpertiseDTO>> FindAllAsync()
    {
        var competenceDmExpertise = await _consultaionProfileService.GetAllAsync();
        return _mapper.Map<List<DomaineExpertiseDTO>>(competenceDmExpertise);
    }

    public async Task<DomaineExpertiseDTO> FindByIdAsync(int id)
    {
        var competenceDmExpertise = await _consultaionProfileService.GetAsync(id);
        return _mapper.Map<DomaineExpertiseDTO>(competenceDmExpertise);
    }

    public async Task<DomaineExpertiseDTO> UpdateAsync(int id, DomaineExpertiseUpdateDTO entity)
    {
        var existingcompetenceDm = await _consultaionProfileService.GetAsync(id);
        if (existingcompetenceDm == null)
            return null;

        _mapper.Map(entity, existingcompetenceDm);
        await _consultaionProfileService.PutAsync(id, existingcompetenceDm);
        return _mapper.Map<DomaineExpertiseDTO>(existingcompetenceDm);
    }
}
