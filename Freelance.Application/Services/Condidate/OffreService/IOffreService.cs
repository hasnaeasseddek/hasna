using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.ViewModels.DTOs.OffreDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.OffreService;

public interface IOffreService
{
    Task<OffreDTO> FindByIdAsync(int id);
    Task<List<OffreDTO>> FindAllAsync();
    Task<OffreDTO> CreateAsync(OffreCreateDTO entity);
    Task<OffreDTO> UpdateAsync(int id, OffreUpdateDTO entity);
    Task DeleteAsync(int id);
}
