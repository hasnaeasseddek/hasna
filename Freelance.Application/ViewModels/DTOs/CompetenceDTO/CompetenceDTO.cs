using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;
using Freelance.Application.ViewModels.DTOs.CompetenceOffreDTO;
using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.CompetenceDTO;

public partial class CompetenceDTO
{
    public int Id { get; set; }

    public string? Nom { get; set; }
}