using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CompetenceOffreDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.CompetenceOffreService;

internal class CompetenceOffreService : ICompetenceOffreSevice
{
    private readonly IGenericRepository<CompetenceOffre> _competenceOffreRepository;
    private readonly IMapper _mapper;

    public CompetenceOffreService(IGenericRepository<CompetenceOffre> competenceOffreRepository, IMapper mapper)
    {
        _competenceOffreRepository = competenceOffreRepository;
        _mapper = mapper;
    }

    public async Task<CompetenceOffreDTO> FindByIdAsync(int id)
    {
        var competenceOffre = await _competenceOffreRepository.GetAsync(id);
        return _mapper.Map<CompetenceOffreDTO>(competenceOffre);
    }

    public async Task<List<CompetenceOffreDTO>> FindAllAsync()
    {
        var competenceOffre = await _competenceOffreRepository.GetAllAsync();
        return _mapper.Map<List<CompetenceOffreDTO>>(competenceOffre);
    }

    public async Task<CompetenceOffreDTO> CreateAsync(CompetenceOffreCreateDTO entity)
    {
        var competenceOffre = _mapper.Map<CompetenceOffre>(entity);
        var createdcompetenceOffre = await _competenceOffreRepository.PostAsync(competenceOffre);
        return _mapper.Map<CompetenceOffreDTO>(createdcompetenceOffre);
    }

    public async Task<CompetenceOffreDTO> UpdateAsync(int id, CompetenceOffreUpdateDTO entity)
    {
        var existingcompetenceOffre = await _competenceOffreRepository.GetAsync(id);
        if (existingcompetenceOffre == null)
            return null;

        _mapper.Map(entity, existingcompetenceOffre);
        await _competenceOffreRepository.PutAsync(id, existingcompetenceOffre);
        return _mapper.Map<CompetenceOffreDTO>(existingcompetenceOffre);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetenceOffre = await _competenceOffreRepository.GetAsync(id);
        if (existingcompetenceOffre == null)
            return;
        await _competenceOffreRepository.DeleteAsync(id);
    }
}
