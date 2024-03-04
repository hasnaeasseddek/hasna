using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;
using Freelance.Application.ViewModels.DTOs.OffreDTO;
using Freelance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.OffreService;

public class OffreService : IOffreService
{

    private readonly IGenericRepository<Offre> _offreService;
    private readonly IMapper _mapper;

    public OffreService(IGenericRepository<Offre> offreService, IMapper mapper)
    {
        _offreService = offreService;
        _mapper = mapper;
    }

    public async Task<OffreDTO> CreateAsync(OffreCreateDTO entity)
    {
        var competenceDmExpertise = _mapper.Map<Offre>(entity);
        var createdcompetenceDm = await _offreService.PostAsync(competenceDmExpertise);
        return _mapper.Map<OffreDTO>(createdcompetenceDm);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetenceDm = await _offreService.GetAsync(id);
        if (existingcompetenceDm == null)
            return;
        await _offreService.DeleteAsync(id); ;
    }

    public async Task<List<OffreDTO>> FindAllAsync()
    {
        var competenceDmExpertise = await _offreService.GetAllAsync();
        return _mapper.Map<List<OffreDTO>>(competenceDmExpertise);
    }

    public async Task<OffreDTO> FindByIdAsync(int id)
    {
        var competenceDmExpertise = await _offreService.GetAsync(id);
        return _mapper.Map<OffreDTO>(competenceDmExpertise);
    }

    public async Task<OffreDTO> UpdateAsync(int id, OffreUpdateDTO entity)
    {
        var existingcompetenceDm = await _offreService.GetAsync(id);
        if (existingcompetenceDm == null)
            return null;

        _mapper.Map(entity, existingcompetenceDm);
        await _offreService.PutAsync(id, existingcompetenceDm);
        return _mapper.Map<OffreDTO>(existingcompetenceDm);
    }
}
