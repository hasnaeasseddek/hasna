using Freelance.Application.ViewModels.DTOs.MessagerieDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.EntrepriseDTO;

public partial class EntrepriseDTO
{
    public int Id { get; set; }

    public string? RaisonSociale { get; set; }

    public string? Logo { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? Adresse { get; set; }

    public string? Ville { get; set; }
    public string ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
}