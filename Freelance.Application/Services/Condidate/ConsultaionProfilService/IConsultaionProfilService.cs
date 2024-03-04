using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ConsultaionProfilDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ConsultaionProfilService;

public interface IConsultaionProfilService
{
    Task<ConsultaionProfilDTO> FindByIdAsync(int id);
    Task<List<ConsultaionProfilDTO>> FindAllAsync();
    Task<ConsultaionProfilDTO> CreateAsync(ConsultaionProfilCreateDTO entity);
    Task<ConsultaionProfilDTO> UpdateAsync(int id, ConsultaionProfilUpdateDTO entity);
    Task DeleteAsync(int id);
}
