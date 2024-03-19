using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Offres.Commandes.Models
{
    public class DeleteOffreCommande:IRequest<string>
    {
        public int Ido { get; set; }
        public DeleteOffreCommande(int id)
        {
            Ido= id;
        }
    }
}
