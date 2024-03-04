using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;
using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.Services.Condidate.ComptenceDmExpertiseService;

public class ComptenceDmExpertiseService : IComptenceDmExpertiseService
{
    private readonly IGenericRepository<ComptenceDmExpertise> _competenceDmExpertiseRepository;
    private readonly IMapper _mapper;

    public ComptenceDmExpertiseService(IGenericRepository<ComptenceDmExpertise> competenceDmExpertiseRepository, IMapper mapper)
    {
        _competenceDmExpertiseRepository = competenceDmExpertiseRepository;
        _mapper = mapper;
    }

    public async Task<ComptenceDmExpertiseDTO> CreateAsync(ComptenceDmExpertiseCreateDTO entity)
    {
        var competenceDmExpertise = _mapper.Map<ComptenceDmExpertise>(entity);
        var createdcompetenceDm = await _competenceDmExpertiseRepository.PostAsync(competenceDmExpertise);
        return _mapper.Map<ComptenceDmExpertiseDTO>(createdcompetenceDm);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetenceDm = await _competenceDmExpertiseRepository.GetAsync(id);
        if (existingcompetenceDm == null)
            return;
        await _competenceDmExpertiseRepository.DeleteAsync(id);
    }

    public async Task<List<ComptenceDmExpertiseDTO>> FindAllAsync()
    {
        var competenceDmExpertise = await _competenceDmExpertiseRepository.GetAllAsync();
        return _mapper.Map<List<ComptenceDmExpertiseDTO>>(competenceDmExpertise);
    }

    public async Task<ComptenceDmExpertiseDTO> FindByIdAsync(int id)
    {
        var competenceDmExpertise = await _competenceDmExpertiseRepository.GetAsync(id);
        return _mapper.Map<ComptenceDmExpertiseDTO>(competenceDmExpertise);
    }

    public async Task<ComptenceDmExpertiseDTO> UpdateAsync(int id, ComptenceDmExpertiseUpdateDTO entity)
    {
        var existingcompetenceDm = await _competenceDmExpertiseRepository.GetAsync(id);
        if (existingcompetenceDm == null)
            return null;

        _mapper.Map(entity, existingcompetenceDm);
        await _competenceDmExpertiseRepository.PutAsync(id, existingcompetenceDm);
        return _mapper.Map<ComptenceDmExpertiseDTO>(existingcompetenceDm);
    }
}
