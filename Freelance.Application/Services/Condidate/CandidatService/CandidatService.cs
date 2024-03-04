using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.Services.Condidate.CandidatService
{
    public class CandidatService : ICandidateService
    {

        private readonly IGenericRepository<Candidat> _condidateRepository;
        private readonly ICondidatRepository _condidateRepositoryTwo;
        private readonly IMapper _mapper;

        public CandidatService(IGenericRepository<Candidat> condidateRepository, IMapper mapper, ICondidatRepository condidateRepositoryTwo)
        {
            _condidateRepository = condidateRepository;
            _condidateRepositoryTwo = condidateRepositoryTwo;
            _mapper = mapper;
        }

        public async Task<CandidatDTO> FindByIdAsync(int id)
        {
            var candidat = await _condidateRepository.GetAsync(id);
            return _mapper.Map<CandidatDTO>(candidat);
        }

        public async Task<List<CandidatDTO>> FindAllAsync()
        {
            var candidat = await _condidateRepository.GetAllAsync();
            return _mapper.Map<List<CandidatDTO>>(candidat);
        }

        public async Task<CandidatDTO> CreateAsync(CandidatCreateDTO entity)
        {
            var candidat = _mapper.Map<Candidat>(entity);
            var createdCandidat = await _condidateRepository.PostAsync(candidat);
            return _mapper.Map<CandidatDTO>(createdCandidat);
        }

        public async Task<CandidatDTO> UpdateAsync(int id, CandidatUpdateDTO entity)
        {
            var existingCandidat = await _condidateRepository.GetAsync(id);
            if (existingCandidat == null)
                return null;

            _mapper.Map(entity, existingCandidat);
            await _condidateRepository.PutAsync(id, existingCandidat);
            return _mapper.Map<CandidatDTO>(existingCandidat);
        }

        public async Task DeleteAsync(int id)
        {
            var existingCandidat = await _condidateRepository.GetAsync(id);
            if (existingCandidat == null)
                return;
            await _condidateRepository.DeleteAsync(id);
        }

        public async Task<Candidat> GetCandidatWithDetailsAsync(int candidatId)
        {
            return await _condidateRepositoryTwo.GetCandidatWithDetailsAsync(candidatId);
        }

        public async Task<List<Candidat>> GetAllCandidatsWithDetailsAsync()
        {
            return await _condidateRepositoryTwo.GetAllCandidatsWithDetailsAsync();
        }
    }
}