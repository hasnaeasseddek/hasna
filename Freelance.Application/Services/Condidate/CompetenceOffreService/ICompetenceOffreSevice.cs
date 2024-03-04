using Freelance.Application.ViewModels.DTOs.CompetenceOffreDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.CompetenceOffreService
{
    public interface ICompetenceOffreSevice
    {
        Task<CompetenceOffreDTO> FindByIdAsync(int id);
        Task<List<CompetenceOffreDTO>> FindAllAsync();
        Task<CompetenceOffreDTO> CreateAsync(CompetenceOffreCreateDTO entity);
        Task<CompetenceOffreDTO> UpdateAsync(int id, CompetenceOffreUpdateDTO entity);
        Task DeleteAsync(int id);
    }
}
