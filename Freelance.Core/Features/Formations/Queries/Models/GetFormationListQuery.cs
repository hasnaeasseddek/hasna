using Freelance.Core.Features.Formations.Queries.Results;
using Freelance.Core.Features.Offres.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Formations.Queries.Models
{
    public class GetFormationListQuery : IRequest<List<GetFormationListResponse>>
    {
    }
}
