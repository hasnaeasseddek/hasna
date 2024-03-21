using Freelance.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Candidates.Commandes.Models
{
    public class AddCandidateCommandes : IRequest<string>
    {
        public string IdUserReference { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Tele { get; set; }
        public string? GitHub { get; set; }
        public string? LinkedIn { get; set; }
        public string? Titre { get; set; }
        public string? Gender { get; set; }
        //public byte[]? Avatar { get; set; }
        public string? Adresse { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string? Mobilite { get; set; }
        public string? Disponibilite { get; set; }
        public string? Ville { get; set; }


        public List<FormationCandidatAdd>? FormationsCandidat { get; set; }

        public List<ExperienceCandidatAdd>? ExperiencesCandidat { get; set; }

        public List<ProjetCandidatAdd>? ProjetsCandidat { get; set; }
    }
    public class FormationCandidatAdd
    {
        public string? Niveau { get; set; }
        public string? Ecole { get; set; }
        public string? Diplome { get; set; }
        public string? Description { get; set; }
        public string? Ville { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
    }
    public class ExperienceCandidatAdd
    {
        public string? Titre { get; set; }
        public string? Local { get; set; }
        public string? Description { get; set; }
        public string? Ville { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
    }
    public class ProjetCandidatAdd
    {
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
    }
}
