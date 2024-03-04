using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;
using Freelance.Application.ViewModels.DTOs.CompetenceOffreDTO;
using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Freelance.Application.ViewModels.DTOs.CompetenceDTO;

public partial class CompetenceCreateDTO
{
    public string? Nom { get; set; }
}