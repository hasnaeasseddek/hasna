using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.ViewModels.DTOs.MessagerieDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.MessagerieService;

public interface IMessagerieService
{
    Task<MessagerieDTO> FindByIdAsync(int id);
    Task<List<MessagerieDTO>> FindAllAsync();
    Task<MessagerieDTO> CreateAsync(MessagerieCreateDTO entity);
    Task<MessagerieDTO> UpdateAsync(int id, MessagerieUpdateDTO entity);
    Task DeleteAsync(int id);
}
