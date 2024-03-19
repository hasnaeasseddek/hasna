using Freelance.Core.Features.Offres.Queries.Results;
using Freelance.Core.Wrappers;
using Freelance.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Offres.Queries.Models
{
    public class GetOffrePaginatedListQuery : IRequest<PaginatedResult<GetOffrePaginatedListResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string[]? OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
