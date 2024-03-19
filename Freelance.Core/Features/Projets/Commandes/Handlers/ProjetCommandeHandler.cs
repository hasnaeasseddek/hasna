using AutoMapper;
using Freelance.Core.Features.Formations.Commandes.Models;
using Freelance.Core.Features.Projets.Commandes.Models;
using Freelance.Data.Entities;
using Freelance.Service.OffreService.Abstracts;
using Freelance.Service.OffreService.Implementations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Projets.Commandes.Handlers
{
    public class ProjetCommandeHandler : IRequestHandler<AddProjetCommandes, string>,
                                            IRequestHandler<EditProjetCommandes, string>,
                                            IRequestHandler<DeleteProjetCommandes, string>
    {
        private readonly IProjetService _projetService;
        private readonly IMapper _mapper;

        public ProjetCommandeHandler(IProjetService projetService, IMapper mapper)
        {
            _projetService = projetService;
            _mapper = mapper;
        }

        public async Task<string> Handle(AddProjetCommandes request, CancellationToken cancellationToken)
        {
            var projet = _mapper.Map<Projet>(request);
            var result = await _projetService.AddAsync(projet);
            if (result == "Success")
            {
                return "Added Successfully";
            }
            else
            {
                return "Bad Request";
            }
        }

        public async Task<string> Handle(EditProjetCommandes request, CancellationToken cancellationToken)
        {
            var projet = await _projetService.GetProjectsByIDAsync(request.IdProj);
            if (projet == null)
            {
                return "offre is not found";
            }
            // map between request and offre
            var projetMapper = _mapper.Map<Projet>(request);
            // call service that make edit
            var result = await _projetService.EditAsync(projetMapper);
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

        public async Task<string> Handle(DeleteProjetCommandes request, CancellationToken cancellationToken)
        {
            var projet = await _projetService.GetProjectsByIDAsync(request.IdProj);
            if (projet == null)
            {
                return "offre is not found";
            }
            // call service that make edit
            var result = await _projetService.DeleteAsync(projet);

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
    }
}
