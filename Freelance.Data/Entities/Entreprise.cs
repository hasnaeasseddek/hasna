using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Data.Entities
{
    public class Entreprise
    {
        public Entreprise()
        {
            Offres = new HashSet<Offre>();
        }
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? RaisonSociale { get; set; }

        public byte[]? Logo { get; set; }

        public DateTime? DateCreation { get; set; }

        public string? Adresse { get; set; }

        public string? Ville { get; set; }

        public virtual ICollection<Offre> Offres { get; set; }
    }
}
