using Freelance.Core.Features.Entreprises.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Entreprises.Queries.Models
{
    public class GetEntrepriseListQuery : IRequest<List<GetEntrepriseListResponse>>
    {
    }
}
