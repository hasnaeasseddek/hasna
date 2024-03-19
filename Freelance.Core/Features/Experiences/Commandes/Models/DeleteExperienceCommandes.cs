using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Experiences.Commandes.Models
{
    public class DeleteExperienceCommandes : IRequest<string>
    {
        public int IdExp { get; set; }
        public DeleteExperienceCommandes(int id)
        {
            IdExp = id;
        }
    }
}
