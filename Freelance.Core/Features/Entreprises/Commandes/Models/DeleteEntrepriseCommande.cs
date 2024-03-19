using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Entreprises.Commandes.Models
{
    public class DeleteEntrepriseCommande  :IRequest<string>
    {
        public int Ide { get; set; }
        public DeleteEntrepriseCommande(int id)
        {
            Ide=id;
        }

    }
}
