using AutoMapper;
using Freelace.Service.OffreService.Abstracts;
using Freelace.Service.OffreService.Implementations;
using Freelance.Core.Features.Formations.Queries.Models;
using Freelance.Core.Features.Formations.Queries.Results;
using Freelance.Core.Features.Offres.Queries.Models;
using Freelance.Core.Features.Offres.Queries.Results;
using Freelance.Service.OffreService.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Formations.Queries.Handlers
{
    public class FormationQueryHandler : IRequestHandler<GetFormationListQuery, List<GetFormationListResponse>>,
                                        IRequestHandler<GetFormationByIDQuery, GetSingleFormationResponse>
    {
    private readonly IFormationService _formationService;
    private readonly IMapper _mapper;

    public FormationQueryHandler(IFormationService formationService, IMapper mapper)
    {
        _formationService = formationService;
        _mapper = mapper;
    }


    public async Task<List<GetFormationListResponse>> Handle(GetFormationListQuery request, CancellationToken cancellationToken)
    {
        var formationList = await _formationService.GetFormationsListAsync();
        var formationListMapper = _mapper.Map<List<GetFormationListResponse>>(formationList);
        return formationListMapper;
    }

    public async Task<GetSingleFormationResponse> Handle(GetFormationByIDQuery request, CancellationToken cancellationToken)
    {
        var formation = await _formationService.GetFormationsByIDAsync(request.IdFormation);
        if (formation == null)
        {
            //return NotFount<GetSingleOffreResponse>("Ogject not found");
            return null;
        }

        var result = _mapper.Map<GetSingleFormationResponse>(formation);
        return result;
    }


}
}

