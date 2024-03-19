using AutoMapper;
using Freelance.Core.Features.Experiences.Commandes.Models;
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

namespace Freelance.Core.Features.Experiences.Commandes.Handlers
{
    internal class ExperienceCommandeHandler : IRequestHandler<AddExperienceCommandes, string>,
                                            IRequestHandler<EditExperienceCommandes, string>,
                                            IRequestHandler<DeleteExperienceCommandes, string>
    {
        private readonly IExperienceService _experienceService ;
        private readonly IMapper _mapper;

        public ExperienceCommandeHandler(IExperienceService experienceService, IMapper mapper)
        {
            _experienceService = experienceService;
            _mapper = mapper;
        }

        public async Task<string> Handle(AddExperienceCommandes request, CancellationToken cancellationToken)
        {
            var experience = _mapper.Map<Experience>(request);
            var result = await _experienceService.AddAsync(experience);
            if (result == "Success")
            {
                return "Added Successfully";
            }
            else
            {
                return "Bad Request";
            }
        }

        public async Task<string> Handle(EditExperienceCommandes request, CancellationToken cancellationToken)
        {
            var experience = await _experienceService.GetExperiencesByIDAsync(request.IdExp);
            if (experience == null)
            {
                return "offre is not found";
            }
            // map between request and offre
            var experienceMapper = _mapper.Map<Experience>(request);
            // call service that make edit
            var result = await _experienceService.EditAsync(experienceMapper);
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

        public async Task<string> Handle(DeleteExperienceCommandes request, CancellationToken cancellationToken)
        {
            var experience = await _experienceService.GetExperiencesByIDAsync(request.IdExp);
            if (experience == null)
            {
                return "offre is not found";
            }
            // call service that make edit
            var result = await _experienceService.DeleteAsync(experience);

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
