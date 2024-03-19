using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Data.Entities
{
    public class Experience
    {
        public int Id { get; set; }

        public string? Titre { get; set; }

        public string? Local { get; set; }

        public string? Description { get; set; }

        public string? Ville { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        public int? IdCondidat { get; set; }
        [ForeignKey("IdCondidat")]
        public virtual Candidat? Candidat { get; set; }
    }
}
