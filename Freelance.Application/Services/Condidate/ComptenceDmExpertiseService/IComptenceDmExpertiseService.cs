using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;

namespace Freelance.Application.Services.Condidate.ComptenceDmExpertiseService;

public interface IComptenceDmExpertiseService
{
    Task<ComptenceDmExpertiseDTO> FindByIdAsync(int id);
    Task<List<ComptenceDmExpertiseDTO>> FindAllAsync();
    Task<ComptenceDmExpertiseDTO> CreateAsync(ComptenceDmExpertiseCreateDTO entity);
    Task<ComptenceDmExpertiseDTO> UpdateAsync(int id, ComptenceDmExpertiseUpdateDTO entity);
    Task DeleteAsync(int id);
}
