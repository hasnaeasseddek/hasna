﻿namespace Freelance.Domain.Models;

public partial class Experience
{
    public int Id { get; set; }

    public string? Titre { get; set; }

    public string? Local { get; set; }

    public string? Description { get; set; }

    public string? Ville { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public int? IdCondidat { get; set; }

    public virtual Candidat? IdCondidatNavigation { get; set; }
    public Experience() { }

    public Experience(
        string? titre,
        string? local, 
        string? description, 
        string? ville, 
        DateTime? dateDebut, 
        DateTime? dateFin 
        )
    {
        Titre = titre;
        Local = local;
        Description = description;
        Ville = ville;
        DateDebut = dateDebut;
        DateFin = dateFin;
    }
}