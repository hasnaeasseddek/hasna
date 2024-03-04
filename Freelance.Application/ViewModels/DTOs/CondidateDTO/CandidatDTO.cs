using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.CondidateDTO;

public partial class CandidatDTO
{
    public int Id { get; set; }
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
    public List<CondidatCompGetDTO> CondidatComps { get; set; }
    public List<ExperienceGetDTO> Experiences { get; set; }
    public List<FormationGetDTO> Formations { get; set; }
    public List<ProjetGetDTO> Projets { get; set; }
}
