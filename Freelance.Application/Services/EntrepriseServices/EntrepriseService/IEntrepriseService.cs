using Freelance.Application.ViewModels.DTOs.EntrepriseDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.EntrepriseServices.EntrepriseService;

public interface IEntrepriseService
{
    Task<EntrepriseDTO> FindByIdAsync(int id);
    Task<List<EntrepriseDTO>> FindAllAsync();
    Task<EntrepriseDTO> CreateAsync(EntrepriseCreateDTO entity);
    Task<EntrepriseDTO> UpdateAsync(int id, EntrepriseUpdateDTO entity);
    Task DeleteAsync(int id);
}
