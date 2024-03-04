using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ExperienceService;

public interface IExperienceService
{
    Task<ExperienceGetDTO> FindByIdAsync(int id);
    Task<List<ExperienceGetDTO>> FindAllAsync();
    Task<ExperienceGetDTO> CreateAsync(ExperienceCreateDTO entity);
    Task<IEnumerable<ExperienceGetDTO>> CreateRangeAsync(IEnumerable<ExperienceCreateDTO> entities);
    Task<ExperienceGetDTO> UpdateAsync(int id, ExperienceUpdateDTO entity);
    Task DeleteAsync(int id);
}
