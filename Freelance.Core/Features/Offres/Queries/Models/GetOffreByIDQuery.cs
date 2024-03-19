using Freelance.Core.Features.Offres.Queries.Results;
using Freelance.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Offres.Queries.Models
{
    public class GetOffreByIDQuery : IRequest<GetSingleOffreResponse>
    {
        public int IdOffrer { get; set; }
        public GetOffreByIDQuery(int id)
        {
            IdOffrer=id;
        }
    }
}
