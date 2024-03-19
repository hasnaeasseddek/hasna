using AutoMapper;
using Freelance.Core.Features.Formations.Queries.Models;
using Freelance.Core.Features.Formations.Queries.Results;
using Freelance.Core.Features.Projets.Queries.Models;
using Freelance.Core.Features.Projets.Queries.Result;
using Freelance.Service.OffreService.Abstracts;
using Freelance.Service.OffreService.Implementations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Projets.Queries.Handlers
{
    public class ProjetQueryHandler : IRequestHandler<GetProjetListQuery, List<GetProjetListResponse>>,
                                        IRequestHandler<GetProjetByIDQuery, GetSingleProjetResponse>
    {
        private readonly IProjetService _projetService;
        private readonly IMapper _mapper;

        public ProjetQueryHandler(IProjetService projetService, IMapper mapper)
        {
            _projetService = projetService;
            _mapper = mapper;
        }

        public async Task<List<GetProjetListResponse>> Handle(GetProjetListQuery request, CancellationToken cancellationToken)
        {
            var projetist = await _projetService.GetProjectsListAsync();
            var projetistMapper = _mapper.Map<List<GetProjetListResponse>>(projetist);
            return projetistMapper;
        }

        public async Task<GetSingleProjetResponse> Handle(GetProjetByIDQuery request, CancellationToken cancellationToken)
        {
            var projet = await _projetService.GetProjectsByIDAsync(request.IdProjet);
            if (projet == null)
            {
                //return NotFount<GetSingleOffreResponse>("Ogject not found");
                return null;
            }

            var result = _mapper.Map<GetSingleProjetResponse>(projet);
            return result;
        }
    }
}
