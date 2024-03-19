using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Data.Entities
{
    public class Candidat
    {
        public int Id { get; set; }
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
        public string? bumberOfLikes { get; set;}

        public virtual ICollection<Formation>? Formations { get; set; }
        public virtual ICollection<Experience>? Experiences { get; set; }
        public virtual ICollection<Projet>? Projets { get; set; }
        
    }
}
