using Freelance.Core.Features.Formations.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Formations.Queries.Models
{
    public class GetFormationByIDQuery : IRequest<GetSingleFormationResponse>
    {
        public int IdFormation { get; set; }
        public GetFormationByIDQuery(int id)
        {
            IdFormation = id;
        }
    }
}
