using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Data.Entities
{
    public partial class Offre
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string? Titre { get; set; }
        
        public string? Descrpition { get; set; }

        public DateTime? Date { get; set; }

        public string? Dure { get; set; }
        [StringLength(500)]
        public string? Adresse { get; set; }

        public string? Ville { get; set; }

        public DateTime? DatePub { get; set; }
        public int? IdEntreprise { get; set; }
        [ForeignKey("IdEntreprise")]
        public virtual Entreprise? Entreprise { get; set; }
    }
}
