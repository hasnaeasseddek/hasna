using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ProjetService;

public interface IProjetService
{
    Task<ProjetGetDTO> FindByIdAsync(int id);
    Task<List<ProjetGetDTO>> FindAllAsync();
    Task<ProjetGetDTO> CreateAsync(ProjetCreateDTO entity);
    Task<IEnumerable<ProjetGetDTO>> CreateRangeAsync(IEnumerable<ProjetCreateDTO> entities);
    Task<ProjetGetDTO> UpdateAsync(int id, ProjetUpdateDTO entity);
    Task DeleteAsync(int id);
}
