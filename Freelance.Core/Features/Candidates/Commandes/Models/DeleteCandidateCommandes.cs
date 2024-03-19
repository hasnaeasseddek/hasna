using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Candidates.Commandes.Models
{
    public class DeleteCandidateCommandes : IRequest<string>
    {
        public int Idc { get; set; }
        public DeleteCandidateCommandes(int id)
        {
            Idc = id;
        }
    }
}
