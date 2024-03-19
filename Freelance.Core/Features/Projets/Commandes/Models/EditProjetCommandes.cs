using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Projets.Commandes.Models
{
    public class EditProjetCommandes : IRequest<string>
    {
        public int IdProj { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }

    }
}
