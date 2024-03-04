using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.ConsultaionProfilDTO;
using Freelance.Application.ViewModels.DTOs.ConsultaionProfilDTO;
using Freelance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ConsultaionProfilService;

public class ConsultaionProfilService : IConsultaionProfilService
{
    private readonly IGenericRepository<ConsultaionProfil> _consultaionProfileService;
    private readonly IMapper _mapper;

    public ConsultaionProfilService(IGenericRepository<ConsultaionProfil> experieceService, IMapper mapper)
    {
        _consultaionProfileService = experieceService;
        _mapper = mapper;
    }

    public async Task<ConsultaionProfilDTO> CreateAsync(ConsultaionProfilCreateDTO entity)
    {
        var consultaionProfil = _mapper.Map<ConsultaionProfil>(entity);
        var createdExperience = await _consultaionProfileService.PostAsync(consultaionProfil);
        return _mapper.Map<ConsultaionProfilDTO>(createdExperience);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetenceDm = await _consultaionProfileService.GetAsync(id);
        if (existingcompetenceDm == null)
            return;
        await _consultaionProfileService.DeleteAsync(id);
    }

    public async Task<List<ConsultaionProfilDTO>> FindAllAsync()
    {
        var competenceDmExpertise = await _consultaionProfileService.GetAllAsync();
        return _mapper.Map<List<ConsultaionProfilDTO>>(competenceDmExpertise);
    }

    public async Task<ConsultaionProfilDTO> FindByIdAsync(int id)
    {
        var competenceDmExpertise = await _consultaionProfileService.GetAsync(id);
        return _mapper.Map<ConsultaionProfilDTO>(competenceDmExpertise);
    }

    public async Task<ConsultaionProfilDTO> UpdateAsync(int id, ConsultaionProfilUpdateDTO entity)
    {
        var existingcompetenceDm = await _consultaionProfileService.GetAsync(id);
        if (existingcompetenceDm == null)
            return null;

        _mapper.Map(entity, existingcompetenceDm);
        await _consultaionProfileService.PutAsync(id, existingcompetenceDm);
        return _mapper.Map<ConsultaionProfilDTO>(existingcompetenceDm);
    }

}
