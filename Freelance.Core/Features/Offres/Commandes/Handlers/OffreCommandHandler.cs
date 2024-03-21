using AutoMapper;
using Freelace.Service.OffreService.Abstracts;
using Freelace.Service.OffreService.Implementations;
using Freelance.Core.Features.Offres.Commandes.Models;
using Freelance.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Offres.Commandes.Handlers
{
    public class OffreCommandHandler : IRequestHandler<AddOffreCommand, string>,
                                        IRequestHandler<EditOffreCommand, string>,
                                        IRequestHandler<DeleteOffreCommande, string>
    {
        private readonly IOffreService _offreService;
        private readonly IMapper _mapper;

        public OffreCommandHandler(IOffreService offreService, IMapper mapper)
        {
            _offreService = offreService;
            _mapper = mapper;

        }


        public async Task<string> Handle(AddOffreCommand request, CancellationToken cancellationToken)
        {
            // map between request and offre
            var offreMapper = _mapper.Map<Offre>(request);
            //add
            var result = await _offreService.AddAsync(offreMapper);
            //check condition
            
            //return response
            if(result== "Success")
            {
                return "Added Successfully";
            }
            else
            {
                return "Bad Request";
            }
        }

        public async Task<string> Handle(EditOffreCommand request, CancellationToken cancellationToken)
        {
            // check if id exist or not
            var offre = await _offreService.GetOffresByIDAsync(request.Ido);
            if(offre== null)
            {
                return "offre is not found";
            }
            // map between request and offre
            var offreMapper = _mapper.Map(request,offre);
            // call service that make edit
            var result = await _offreService.EditAsync(offreMapper);

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
        
        public async Task<string> Handle(DeleteOffreCommande request, CancellationToken cancellationToken)
        {
            // check if id exist or not
            var offre = await _offreService.GetOffresByIDAsync(request.Ido);
            if (offre == null)
            {
                return "offre is not found";
            }
            // call service that make edit
            var result = await _offreService.DeleteAsync(offre);

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
