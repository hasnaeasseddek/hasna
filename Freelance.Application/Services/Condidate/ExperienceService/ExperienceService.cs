using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.Services.Condidate.ExperienceService;

internal class ExperienceService : IExperienceService
{

    private readonly IGenericRepository<Experience> _experienceService;
    private readonly IMapper _mapper;

    public ExperienceService(IGenericRepository<Experience> experieceService, IMapper mapper)
    {
        _experienceService = experieceService;
        _mapper = mapper;
    }

    public async Task<ExperienceGetDTO> CreateAsync(ExperienceCreateDTO entity)
    {
        var experience = _mapper.Map<Experience>(entity);
        var createdExperience = await _experienceService.PostAsync(experience);
        return _mapper.Map<ExperienceGetDTO>(createdExperience);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetenceDm = await _experienceService.GetAsync(id);
        if (existingcompetenceDm == null)
            return;
        await _experienceService.DeleteAsync(id);
    }

    public async Task<List<ExperienceGetDTO>> FindAllAsync()
    {
        var competenceDmExpertise = await _experienceService.GetAllAsync();
        return _mapper.Map<List<ExperienceGetDTO>>(competenceDmExpertise);
    }

    public async Task<ExperienceGetDTO> FindByIdAsync(int id)
    {
        var competenceDmExpertise = await _experienceService.GetAsync(id);
        return _mapper.Map<ExperienceGetDTO>(competenceDmExpertise);
    }

    public async Task<ExperienceGetDTO> UpdateAsync(int id, ExperienceUpdateDTO entity)
    {
        var existingcompetenceDm = await _experienceService.GetAsync(id);
        if (existingcompetenceDm == null)
            return null;

        _mapper.Map(entity, existingcompetenceDm);
        await _experienceService.PutAsync(id, existingcompetenceDm);
        return _mapper.Map<ExperienceGetDTO>(existingcompetenceDm);
    }

    public async Task<IEnumerable<ExperienceGetDTO>> CreateRangeAsync(IEnumerable<ExperienceCreateDTO> entities)
    {
        var experienceEntities = _mapper.Map<IEnumerable<Experience>>(entities);
        var createdExperience = await _experienceService.PostRangeAsync(experienceEntities);
        return _mapper.Map<IEnumerable<ExperienceGetDTO>>(createdExperience);
    }
}
