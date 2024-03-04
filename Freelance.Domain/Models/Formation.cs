namespace Freelance.Domain.Models;

public partial class Formation
{
    public int Id { get; set; }

    public string? Niveau { get; set; }

    public string? Ecole { get; set; }
    public string? Diplome { get; set; }

    public string? Description { get; set; }

    public string? Ville { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public int? IdCondidat { get; set; }

    public virtual Candidat? IdCondidatNavigation { get; set; }
    public Formation() { }

    public Formation(
        string? niveau,
        string? ecole, 
        string? diplome, 
        string? description, 
        string? ville, 
        DateTime? dateDebut, 
        DateTime? dateFin
        )
    {
        Niveau = niveau;
        Ecole = ecole;
        Diplome = diplome;
        Description = description;
        Ville = ville;
        DateDebut = dateDebut;
        DateFin = dateFin;
    }
}