using Freelance.Core.Features.Formations.Queries.Results;
using Freelance.Core.Features.Projets.Queries.Result;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Projets.Queries.Models
{
    public class GetProjetByIDQuery : IRequest<GetSingleProjetResponse>
    {
        public int IdProjet { get; set; }
        public GetProjetByIDQuery(int id)
        {
            IdProjet = id;
        }
    }
}
