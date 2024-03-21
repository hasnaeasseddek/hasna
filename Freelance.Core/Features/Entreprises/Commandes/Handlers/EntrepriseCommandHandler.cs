using AutoMapper;
using Freelance.Core.Features.Entreprises.Commandes.Models;
using Freelance.Data.Entities;
using Freelance.Service.OffreService.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Entreprises.Commandes.Handlers
{
    public class EntrepriseCommandHandler : IRequestHandler<AddEntrepriseCommande, string>,
                                            IRequestHandler<EditEntrepriseCommand, string>,
                                            IRequestHandler<DeleteEntrepriseCommande, string>
    {
        private readonly IEntrepriseService _entrepriseService;
        private readonly IMapper _mapper;

        public EntrepriseCommandHandler(IEntrepriseService entrepriseService, IMapper mapper)
        {
            _entrepriseService = entrepriseService;
            _mapper = mapper;
        }

        public async Task<string> Handle(AddEntrepriseCommande request, CancellationToken cancellationToken)
        {
            var entreprise = _mapper.Map<Entreprise>(request);
            var result = await _entrepriseService.AddAsync(entreprise);
            if (result == "Success")
            {
                return "Added Successfully";
            }
            else
            {
                return "Bad Request";
            }

        }

        

        async Task<string> IRequestHandler<EditEntrepriseCommand, string>.Handle(EditEntrepriseCommand request, CancellationToken cancellationToken)
        {
            var entrep = await _entrepriseService.GetEntreprisesByIDAsync(request.Ide);
            if (entrep == null)
            {
                return "entreprise is not found";
            }
            // map between request and offre
            var entrepMapper=_mapper.Map(request,entrep);
            // call service that make edit
            var result = await _entrepriseService.EditAsync(entrepMapper);
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


        public async Task<string> Handle(DeleteEntrepriseCommande request, CancellationToken cancellationToken)
        {
            var entrep = await _entrepriseService.GetEntreprisesByIDAsync(request.Ide);
            if (entrep == null)
            {
                return "entreprise is not found";
            }
            // call service that make edit
            var result = await _entrepriseService.DeleteAsync(entrep);

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
