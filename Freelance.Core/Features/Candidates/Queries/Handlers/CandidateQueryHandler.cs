using AutoMapper;
using Freelance.Core.Features.Candidates.Queries.Models;
using Freelance.Core.Features.Candidates.Queries.Results;
using Freelance.Core.Features.Entreprises.Queries.Models;
using Freelance.Core.Features.Entreprises.Queries.Results;
using Freelance.Service.OffreService.Abstracts;
using Freelance.Service.OffreService.Implementations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Candidates.Queries.Handlers
{
    public class CandidateQueryHandler : IRequestHandler<GetCandidateListQuery, List<GetCandidateListResponse>>,
                                        IRequestHandler<GetCandidateByIDQuery, GetSingleCandidateResponse>
    {

        private readonly ICandidatService _candidatService;
        private readonly IMapper _mapper;

        public CandidateQueryHandler(ICandidatService candidatService, IMapper mapper)
        {
            _candidatService = candidatService;
            _mapper = mapper;
        }




        public async Task<List<GetCandidateListResponse>> Handle(GetCandidateListQuery request, CancellationToken cancellationToken)
        {
            var candidatList = await _candidatService.GetCandidatsListAsync();
            var candidListMapper = _mapper.Map<List<GetCandidateListResponse>>(candidatList);
            return candidListMapper;
        }

        public async Task<GetSingleCandidateResponse> Handle(GetCandidateByIDQuery request, CancellationToken cancellationToken)
        {
            var candid = await _candidatService.GetCandidatsByIDAsync(request.IdCandidat);
            if (candid == null) return null;

            var res = _mapper.Map<GetSingleCandidateResponse>(candid);
            return res;
        }
    }
}
