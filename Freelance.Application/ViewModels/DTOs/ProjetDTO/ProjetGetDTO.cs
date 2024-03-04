using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.ProjetDTO;

public partial class ProjetGetDTO
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public string? Description { get; set; }

    public string? Link { get; set; }

    public int? IdCondidat { get; set; }
}