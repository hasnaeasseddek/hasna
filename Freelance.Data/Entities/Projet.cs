using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Data.Entities
{
    public class Projet
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }

        public int? IdCondidat { get; set; }
        [ForeignKey("IdCondidat")]

        public virtual Candidat? Candidat { get; set; }
    }
}
