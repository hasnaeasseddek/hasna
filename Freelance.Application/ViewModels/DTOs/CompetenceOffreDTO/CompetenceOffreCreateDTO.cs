using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Application.ViewModels.DTOs.OffreDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.CompetenceOffreDTO;

public partial class CompetenceOffreCreateDTO
{
    public int? IdCompetence { get; set; }

    public int? IdOffre { get; set; }
}