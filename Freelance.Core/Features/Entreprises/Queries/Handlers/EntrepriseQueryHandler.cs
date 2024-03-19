using AutoMapper;
using Freelance.Core.Features.Entreprises.Queries.Models;
using Freelance.Core.Features.Entreprises.Queries.Results;
using Freelance.Core.Features.Offres.Queries.Results;
using Freelance.Data.Entities;
using Freelance.Service.OffreService.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Entreprises.Queries.Handlers
{
    public class EntrepriseQueryHandler : IRequestHandler<GetEntrepriseListQuery, List<GetEntrepriseListResponse>>,
                                        IRequestHandler<GetEntrepriseByIDQuery, GetSingleEntrepriseResponse>
    {
        private readonly IEntrepriseService _entrepriseService;
        private readonly IMapper _mapper;

        public EntrepriseQueryHandler(IEntrepriseService entrepriseService, IMapper mapper)
        {
            _entrepriseService = entrepriseService;
            _mapper = mapper;
        }

        public async Task<List<GetEntrepriseListResponse>> Handle(GetEntrepriseListQuery request, CancellationToken cancellationToken)
        {
            var entrepList = await _entrepriseService.GetEntreprisesListAsync();
            var entrepListMapper = _mapper.Map<List<GetEntrepriseListResponse>>(entrepList);
            return entrepListMapper;
        }
        //public async Task<List<GetEntrepriseListResponse>> Handle(GetEntrepriseListQuery request, CancellationToken cancellationToken)
        //{
        //var entrepList = await _entrepriseService.GetEntreprisesListAsync();
        //var entrepListMapper = _mapper.Map<List<GetEntrepriseListResponse>>(entrepList);
        //return entrepListMapper;
        //}

        public async Task<GetSingleEntrepriseResponse> Handle(GetEntrepriseByIDQuery request, CancellationToken cancellationToken)
        {
            var entrep = await _entrepriseService.GetEntreprisesByIDAsync(request.IdEntreprise);
            if (entrep == null) return null;

            var res = _mapper.Map<GetSingleEntrepriseResponse>(entrep);
            return res;
        }


    }
}
