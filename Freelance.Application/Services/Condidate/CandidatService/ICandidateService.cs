using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.Services.Condidate.CandidatService;

public interface ICandidateService
{
    Task<CandidatDTO> FindByIdAsync(int id);
    Task<List<CandidatDTO>> FindAllAsync();
    Task<CandidatDTO> CreateAsync(CandidatCreateDTO entity);
    Task<CandidatDTO> UpdateAsync(int id, CandidatUpdateDTO entity);
    Task<Candidat> GetCandidatWithDetailsAsync(int candidatId);
    Task<List<Candidat>> GetAllCandidatsWithDetailsAsync();
    Task DeleteAsync(int id);
}
