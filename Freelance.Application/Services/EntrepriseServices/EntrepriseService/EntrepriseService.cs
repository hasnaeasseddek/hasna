using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.EntrepriseDTO;
using Freelance.Application.ViewModels.DTOs.EntrepriseDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.Services.EntrepriseServices.EntrepriseService;

public class EntrepriseService : IEntrepriseService
{

    private readonly IGenericRepository<Entreprise> _EntrepriseService;
    private readonly IMapper _mapper;

    public EntrepriseService(IGenericRepository<Entreprise> offreService, IMapper mapper)
    {
        _EntrepriseService = offreService;
        _mapper = mapper;
    }

    public async Task<EntrepriseDTO> CreateAsync(EntrepriseCreateDTO entity)
    {
        var competenceDmExpertise = _mapper.Map<Entreprise>(entity);
        var createdcompetenceDm = await _EntrepriseService.PostAsync(competenceDmExpertise);
        return _mapper.Map<EntrepriseDTO>(createdcompetenceDm);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetenceDm = await _EntrepriseService.GetAsync(id);
        if (existingcompetenceDm == null)
            return;
        await _EntrepriseService.DeleteAsync(id); ;
    }

    public async Task<List<EntrepriseDTO>> FindAllAsync()
    {
        var competenceDmExpertise = await _EntrepriseService.GetAllAsync();
        return _mapper.Map<List<EntrepriseDTO>>(competenceDmExpertise);
    }

    public async Task<EntrepriseDTO> FindByIdAsync(int id)
    {
        var competenceDmExpertise = await _EntrepriseService.GetAsync(id);
        return _mapper.Map<EntrepriseDTO>(competenceDmExpertise);
    }

    public async Task<EntrepriseDTO> UpdateAsync(int id, EntrepriseUpdateDTO entity)
    {
        var existingcompetenceDm = await _EntrepriseService.GetAsync(id);
        if (existingcompetenceDm == null)
            return null;

        _mapper.Map(entity, existingcompetenceDm);
        await _EntrepriseService.PutAsync(id, existingcompetenceDm);
        return _mapper.Map<EntrepriseDTO>(existingcompetenceDm);
    }
}
