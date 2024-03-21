using AutoMapper;
using Freelance.Core.Features.Candidates.Commandes.Models;
using Freelance.Core.Features.Entreprises.Commandes.Models;
using Freelance.Data.Entities;
using Freelance.Service.OffreService.Abstracts;
using Freelance.Service.OffreService.Implementations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Candidates.Commandes.Handlers
{
    public class CandidateCommandeHandler : IRequestHandler<AddCandidateCommandes, string>,
                                            IRequestHandler<EditCandidateCommandes, string>,
                                            IRequestHandler<DeleteCandidateCommandes, string>
    {
        private readonly ICandidatService _candidatService;
        private readonly IMapper _mapper;

        public CandidateCommandeHandler(ICandidatService candidatService , IMapper mapper)
        {
            _candidatService = candidatService;
            _mapper = mapper;
        }

        public async Task<string> Handle(AddCandidateCommandes request, CancellationToken cancellationToken)
        {
            var candidat = _mapper.Map<Candidat>(request);
            var result = await _candidatService.AddAsync(candidat);
            if (result == "Success")
            {
                return "Added Successfully";
            }
            else
            {
                return "Bad Request";
            }
        }

        public async Task<string> Handle(EditCandidateCommandes request, CancellationToken cancellationToken)
        {
            var candidat = await _candidatService.GetCandidatsByIDAsync(request.Idc);
            if (candidat == null)
            {
                return "Candidat is not found";
            }
            // map between request and offre
            var candidatMapper = _mapper.Map(request,candidat);
            // call service that make edit
            var result = await _candidatService.EditAsync(candidatMapper);
            // return response
            if (result == "Success")
            {
                return "Updateed Successfully";
            }
            else
            {
                return "Bad Request";
            }
        }

        public async Task<string> Handle(DeleteCandidateCommandes request, CancellationToken cancellationToken)
        {
            var candidat = await _candidatService.GetCandidatsByIDAsync(request.Idc);
            if (candidat == null)
            {
                return "candidat is not found";
            }
            // call service that make edit
            var result = await _candidatService.DeleteAsync(candidat);

            // return response
            if (result == "Success")
            {
                return "Deleted Successfully";
            }
            else
            {
                return "Bad Request";
            }
        }
    }
}
