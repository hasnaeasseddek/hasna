using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.ExperienceDTO;

public partial class ExperienceUpdateDTO
{

    public string? Titre { get; set; }

    public string? Local { get; set; }

    public string? Description { get; set; }

    public string? Ville { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public int? IdCondidat { get; set; }

}