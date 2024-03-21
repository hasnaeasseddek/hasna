using AutoMapper;
using Freelance.Core.Features.Candidates.Commandes.Models;
using Freelance.Core.Features.Formations.Commandes.Models;
using Freelance.Data.Entities;
using Freelance.Service.OffreService.Abstracts;
using Freelance.Service.OffreService.Implementations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Formations.Commandes.Handlers
{
    public class FormationCommandeHandler : IRequestHandler<AddFormationCommandes, string>,
                                            IRequestHandler<EditFormationCommandes, string>,
                                            IRequestHandler<DeleteFormationCommandes, string>
    {
        private readonly IFormationService _formationService;
        private readonly IMapper _mapper;

        public FormationCommandeHandler(IFormationService formationService, IMapper mapper)
        {
            _formationService = formationService;
            _mapper = mapper;
        }

        public async Task<string> Handle(AddFormationCommandes request, CancellationToken cancellationToken)
        {
            var formation = _mapper.Map<Formation>(request);
            var result = await _formationService.AddAsync(formation);
            if (result == "Success")
            {
                return "Added Successfully";
            }
            else
            {
                return "Bad Request";
            }
        }

        public async Task<string> Handle(EditFormationCommandes request, CancellationToken cancellationToken)
        {
            var formation = await _formationService.GetFormationsByIDAsync(request.Idf);
            if (formation == null)
            {
                return "formation is not found";
            }
            // map between request and offre
            var formationMapper = _mapper.Map(request,formation);
            // call service that make edit
            var result = await _formationService.EditAsync(formationMapper);
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

        public async Task<string> Handle(DeleteFormationCommandes request, CancellationToken cancellationToken)
        {
            var formation = await _formationService.GetFormationsByIDAsync(request.Idf);
            if (formation == null)
            {
                return "formation is not found";
            }
            // call service that make edit
            var result = await _formationService.DeleteAsync(formation);

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
