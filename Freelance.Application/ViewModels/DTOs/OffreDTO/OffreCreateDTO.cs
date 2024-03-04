using Freelance.Domain.Models;

namespace Freelance.Application.ViewModels.DTOs.OffreDTO;

public partial class OffreCreateDTO
{
    public int Id { get; set; }

    public string? Titre { get; set; }

    public string? Descrpition { get; set; }

    public DateTime? Date { get; set; }

    public string? Dure { get; set; }

    public string? Adresse { get; set; }

    public string? Ville { get; set; }

    public DateTime? DatePub { get; set; }
}