using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Candidates.Queries.Results
{
    public class GetCandidateListResponse
    {
        public int Id { get; set; }
        public string IdUserReference { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Tele { get; set; }
        public string? GitHub { get; set; }
        public string? LinkedIn { get; set; }
        public string? Titre { get; set; }
        public string? Gender { get; set; }
        public byte[]? Avatar { get; set; }
        public string? Adresse { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string? Mobilite { get; set; }
        public string? Disponibilite { get; set; }
        public string? Ville { get; set; }
        public string? bumberOfLikes { get; set; }

        public virtual List<FormationCandidatRes> FormationsCandidat { get; set; }
        public virtual List<ExperienceCandidatRes> ExperiencesCandidat { get; set; }
        public virtual List<ProjetCandidatRes> ProjetsCandidat { get; set; }
    }
    public class FormationCandidatRes
    {
        public int Id { get; set; }
        public string? Niveau { get; set; }
        public string? Ecole { get; set; }
        public string? Diplome { get; set; }
        public string? Description { get; set; }
        public string? Ville { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
    }
    public class ExperienceCandidatRes
    {
        public int Id { get; set; }
        public string? Titre { get; set; }
        public string? Local { get; set; }
        public string? Description { get; set; }
        public string? Ville { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
    }
    public class ProjetCandidatRes
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
    }
}
