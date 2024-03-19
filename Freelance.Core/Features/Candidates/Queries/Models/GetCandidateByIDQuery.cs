using Freelance.Core.Features.Candidates.Queries.Results;
using Freelance.Core.Features.Entreprises.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Candidates.Queries.Models
{
    public class GetCandidateByIDQuery : IRequest<GetSingleCandidateResponse>
    {
        public int IdCandidat { get; set; }
        public GetCandidateByIDQuery(int id)
        {
            IdCandidat = id;
        }
    }
}
