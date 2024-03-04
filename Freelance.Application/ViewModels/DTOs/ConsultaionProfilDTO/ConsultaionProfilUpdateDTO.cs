using Freelance.Application.ViewModels.DTOs.EntrepriseDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.ConsultaionProfilDTO;

public partial class ConsultaionProfilUpdateDTO
{
    public int? IdCondidat { get; set; }

    public int? IdEntreprise { get; set; }

    public DateTime? DateConsultation { get; set; }
}