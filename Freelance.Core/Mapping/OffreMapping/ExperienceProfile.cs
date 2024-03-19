using AutoMapper;
using Freelance.Core.Features.Experiences.Commandes.Models;
using Freelance.Core.Features.Experiences.Queries.Results;
using Freelance.Core.Features.Formations.Commandes.Models;
using Freelance.Core.Features.Formations.Queries.Results;
using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Mapping.OffreMapping
{
    public class ExperienceProfile : Profile
    {
        public ExperienceProfile()
        {
            CreateMap<Experience, GetExperienceListResponse>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Experience, GetSingleExperienceResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            //--------
            CreateMap<AddExperienceCommandes, Experience>();

            CreateMap<EditExperienceCommandes, Experience>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdExp));
        }
    }
}
