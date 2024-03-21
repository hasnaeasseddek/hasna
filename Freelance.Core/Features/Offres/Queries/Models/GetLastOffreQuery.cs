using Freelance.Core.Features.Offres.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Offres.Queries.Models
{
    public class GetLastOffreQuery : IRequest<List<GetOffreListResponse>>
    {
    }
}
