using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Entreprises.Commandes.Models
{
    public class AddEntrepriseCommande : IRequest<string>
    {
        public string? Name { get; set; }
        public string? RaisonSociale { get; set; }

        //public byte[]? Logo { get; set; }

        public DateTime? DateCreation { get; set; }

        public string? Adresse { get; set; }

        public string? Ville { get; set; }
    }
}
