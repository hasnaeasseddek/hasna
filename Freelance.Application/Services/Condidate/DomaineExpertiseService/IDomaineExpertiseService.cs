using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.DomaineExpertise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.DomaineExpertiseService;

public interface IDomaineExpertiseService
{
    Task<DomaineExpertiseDTO> FindByIdAsync(int id);
    Task<List<DomaineExpertiseDTO>> FindAllAsync();
    Task<DomaineExpertiseDTO> CreateAsync(DomaineExpertiseCreateDTO entity);
    Task<DomaineExpertiseDTO> UpdateAsync(int id, DomaineExpertiseUpdateDTO entity);
    Task DeleteAsync(int id);
}
