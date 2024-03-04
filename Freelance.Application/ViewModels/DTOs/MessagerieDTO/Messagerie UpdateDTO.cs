using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.MessagerieDTO;

public partial class MessagerieUpdateDTO
{
    public int? ExpediteurId { get; set; }

    public int? DestinataireId { get; set; }

    public string? Msg { get; set; }

    public DateTime? DateMsg { get; set; }
}