using System.Text.Json.Serialization;

namespace Freelance.Domain.Models;

public  partial class Candidat
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
    public virtual ApplicationUser ApplicationUser { get; set; }

    [JsonIgnore]
    public virtual ICollection<CondidatComp> CondidatComps { get; set; } = new List<CondidatComp>();
    [JsonIgnore]
    public virtual ICollection<ConsultaionProfil> ConsultaionProfils { get; set; } = new List<ConsultaionProfil>();
    [JsonIgnore]
    public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();
    [JsonIgnore]
    public virtual ICollection<Formation> Formations { get; set; } = new List<Formation>();
    [JsonIgnore]
    public virtual ICollection<Messagerie> Messageries { get; set; } = new List<Messagerie>();
    [JsonIgnore]
    public virtual ICollection<Projet> Projets { get; set; } = new List<Projet>();
    public Candidat() { }

    public Candidat(
        string firstName,
        string lastName,
        string email,
        string? titre,
        string? gender,
        string? avatar,
        string? adresse,
        DateTime? dateNaissance,
        string? tele,
        string? mobilite,
        string? disponibilite,
        string? ville,
        string? applicationUserId,
        ICollection<CondidatComp> condidatComps,
        ICollection<Experience> experiences,
        ICollection<Formation> formations, 
        ICollection<Projet> projets)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Titre = titre;
        Gender = gender;
        Avatar = avatar;
        Adresse = adresse;
        DateNaissance = dateNaissance;
        Tele = tele;
        Mobilite = mobilite;
        Disponibilite = disponibilite;
        Ville = ville;
        ApplicationUserId = applicationUserId;
        CondidatComps = condidatComps;
        Experiences = experiences;
        Formations = formations;
        Projets = projets;
    }
}
