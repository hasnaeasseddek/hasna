using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.Services.Condidate.CompetenceService;

internal class CompetenceService : ICompetenceService
{
    readonly IGenericRepository<Competence> _competenceRepository;
    private readonly IMapper _mapper;

    public CompetenceService(IGenericRepository<Competence> competenceRepository, IMapper mapper)
    {
        _competenceRepository = competenceRepository;
        _mapper = mapper;
    }


    public async Task<CompetenceDTO> FindByIdAsync(int id)
    {
        var competence = await _competenceRepository.GetAsync(id);
        return _mapper.Map<CompetenceDTO>(competence);
    }

    public async Task<List<CompetenceDTO>> FindAllAsync()
    {
        var competence = await _competenceRepository.GetAllAsync();
        return _mapper.Map<List<CompetenceDTO>>(competence);
    }

    public async Task<CompetenceDTO> CreateAsync(CompetenceCreateDTO entity)
    {
        var competence = _mapper.Map<Competence>(entity);
        var createdcompetence = await _competenceRepository.PostAsync(competence);
        return _mapper.Map<CompetenceDTO>(createdcompetence);
    }

    public async Task<CompetenceDTO> UpdateAsync(int id, CompetenceUpdateDTO entity)
    {
        var existingcompetence = await _competenceRepository.GetAsync(id);
        if (existingcompetence == null)
            return null;

        _mapper.Map(entity, existingcompetence);
        await _competenceRepository.PutAsync(id, existingcompetence);
        return _mapper.Map<CompetenceDTO>(existingcompetence);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetence = await _competenceRepository.GetAsync(id);
        if (existingcompetence == null)
            return;
        await _competenceRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<CompetenceDTO>> CreateRangeAsync(IEnumerable<CompetenceCreateDTO> entities)
    {
        var Entities = _mapper.Map<IEnumerable<Competence>>(entities);
        var created = await _competenceRepository.PostRangeAsync(Entities);
        return _mapper.Map<IEnumerable<CompetenceDTO>>(created);
    }
}
