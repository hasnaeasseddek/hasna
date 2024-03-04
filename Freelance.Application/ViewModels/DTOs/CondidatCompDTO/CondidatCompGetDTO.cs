using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.CondidatCompDTO;

public partial class CondidatCompGetDTO
{
    public int Id { get; set; }

    public string? Niveau { get; set; }

    public int? IdComp { get; set; }

    public int? IdCond { get; set; }
}