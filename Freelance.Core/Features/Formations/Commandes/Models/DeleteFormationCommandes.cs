using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Formations.Commandes.Models
{
    public class DeleteFormationCommandes : IRequest<string>
    {
        public int Idf { get; set; }
        public DeleteFormationCommandes(int id)
        {
            Idf = id;
        }
    }
}
