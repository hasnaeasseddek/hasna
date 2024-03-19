using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Projets.Commandes.Models
{
    public class AddProjetCommandes : IRequest<string>
    {
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }

        public int? IdCondidat { get; set; }
    }
}
