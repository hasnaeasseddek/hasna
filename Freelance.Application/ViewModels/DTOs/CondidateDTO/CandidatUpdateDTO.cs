using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.CondidateDTO;

public partial class CandidatUpdateDTO
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Titre { get; set; }
    public string? Gender { get; set; }

    public string? Avatar { get; set; }

    public string? Adresse { get; set; }

    public DateTime? DateNaissance { get; set; }

    public string? Tele { get; set; }

    public string? Mobilite { get; set; }

    public string? Disponibilite { get; set; }

    public string? Ville { get; set; }
    public string ApplicationUserId { get; set; }
}
