using AutoMapper;
using Freelance.Core.Features.Offres.Queries.Results;

using Freelace.Service.OffreService.Abstracts;
using Freelance.Core.Features.Offres.Queries.Models;
using MediatR;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Freelance.Core.Wrappers;
using System.Linq.Expressions;
using Freelance.Data.Entities;

namespace Freelance.Core.Features.Offres.Queries.Handlers
{
    public class OffreQueryHandler : IRequestHandler<GetOffreListQuery, List<GetOffreListResponse>>,
                                        IRequestHandler<GetOffreByIDQuery, GetSingleOffreResponse>,
                                        IRequestHandler<GetOffrePaginatedListQuery, PaginatedResult<GetOffrePaginatedListResponse>>
    {
        private readonly IOffreService _offreService;
        private readonly IMapper _mapper;

        public OffreQueryHandler(IOffreService offreService, IMapper mapper)
        {
            _offreService = offreService;
            _mapper = mapper;
        }
        public async Task<List<GetOffreListResponse>> Handle(GetOffreListQuery request, CancellationToken cancellationToken)
        {
            var offreList= await _offreService.GetOffresListAsync();
            var offreListMapper = _mapper.Map<List<GetOffreListResponse>>(offreList);
            return offreListMapper;
        }

        public async Task<GetSingleOffreResponse> Handle(GetOffreByIDQuery request, CancellationToken cancellationToken)
        {
            var offre = await _offreService.GetOffresByIDAsync(request.IdOffrer);
            if (offre == null)
            {
                //return NotFount<GetSingleOffreResponse>("Ogject not found");
                return null;
            }
            
            var result = _mapper.Map<GetSingleOffreResponse>(offre);
            return result;
        }

        public async Task<PaginatedResult<GetOffrePaginatedListResponse>> Handle(GetOffrePaginatedListQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Offre, GetOffrePaginatedListResponse>> expression = e => new GetOffrePaginatedListResponse(
                e.Id,e.Titre,e.Descrpition,e.Date,e.Dure,e.Adresse,e.Ville,e.DatePub,e.IdEntreprise,e.Entreprise.Name);
            //var querable = _offreService.GetOffresQueryable();
            //var PaginatedList = await querable.Select(expression).ToPaginatedListAsync(request.PageNumber, request.PageSize);
            var FilterQuery = _offreService.FolterOffrePaginaterQuerable(request.Search);
            var PaginatedList = await FilterQuery.Select(expression).ToPaginatedListAsync(request.PageNumber, request.PageSize);

            return PaginatedList;
        }
    }
}
