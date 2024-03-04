using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.FormationService;

public interface IFormationService
{
    Task<FormationGetDTO> FindByIdAsync(int id);
    Task<List<FormationGetDTO>> FindAllAsync();
    Task<IEnumerable<FormationGetDTO>> CreateRangeAsync(IEnumerable<FormationCreateDTO> entities);
    Task<FormationGetDTO> CreateAsync(FormationCreateDTO entity);
    Task<FormationGetDTO> UpdateAsync(int id, FormationUpdateDTO entity);
    Task DeleteAsync(int id);
}
