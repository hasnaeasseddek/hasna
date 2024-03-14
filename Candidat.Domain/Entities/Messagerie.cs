using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidat.Domain.Entities
{
    public class Messagerie
    {
        public int Id { get; set; }

        public int? ExpediteurId { get; set; }

        public int? DestinataireId { get; set; }

        public string? Msg { get; set; }

        public DateTime? DateMsg { get; set; }

        public virtual Candidat? Expediteur { get; set; }

        public virtual Entreprise? ExpediteurNavigation { get; set; }
    }
}
