using AutoMapper;
using Freelance.Core.Features.Experiences.Queries.Models;
using Freelance.Core.Features.Experiences.Queries.Results;
using Freelance.Core.Features.Formations.Queries.Models;
using Freelance.Core.Features.Formations.Queries.Results;
using Freelance.Service.OffreService.Abstracts;
using Freelance.Service.OffreService.Implementations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Experiences.Queries.Handlers
{
    public class ExperienceQueryHandler : IRequestHandler<GetExperienceListQuery, List<GetExperienceListResponse>>,
                                        IRequestHandler<GetExperienceByIDQuery, GetSingleExperienceResponse>
    {
        private readonly IExperienceService _experienceService;
        private readonly IMapper _mapper;

        public ExperienceQueryHandler(IExperienceService experienceService, IMapper mapper)
        {
            _experienceService = experienceService;
            _mapper = mapper;
        }

        public async Task<List<GetExperienceListResponse>> Handle(GetExperienceListQuery request, CancellationToken cancellationToken)
        {
            var experienceList = await _experienceService.GetExperiencesListAsync();
            var experienceListMapper = _mapper.Map<List<GetExperienceListResponse>>(experienceList);
            return experienceListMapper;
        }

        public async Task<GetSingleExperienceResponse> Handle(GetExperienceByIDQuery request, CancellationToken cancellationToken)
        {
            var experience = await _experienceService.GetExperiencesByIDAsync(request.IdExperience);
            if (experience == null)
            {
                //return NotFount<GetSingleOffreResponse>("Ogject not found");
                return null;
            }

            var result = _mapper.Map<GetSingleExperienceResponse>(experience);
            return result;
        }
    }
}
