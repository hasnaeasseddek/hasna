using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.FormationDTO;

public partial class FormationCreateDTO
{
    public string? Niveau { get; set; }

    public string? Ecole { get; set; }
    public string? Diplome { get; set; }

    public string? Description { get; set; }

    public string? Ville { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public int? IdCondidat { get; set; }
}