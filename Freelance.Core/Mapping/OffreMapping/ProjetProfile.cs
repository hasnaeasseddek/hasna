using AutoMapper;
using Freelance.Core.Features.Experiences.Commandes.Models;
using Freelance.Core.Features.Experiences.Queries.Results;
using Freelance.Core.Features.Projets.Commandes.Models;
using Freelance.Core.Features.Projets.Queries.Result;
using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Mapping.OffreMapping
{
    public class ProjetProfile : Profile
    {
        public ProjetProfile()
        {
            CreateMap<Projet, GetProjetListResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Projet, GetSingleProjetResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            //--------
            CreateMap<AddProjetCommandes, Projet>();

            CreateMap<EditProjetCommandes, Projet>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdProj));
        }
    }
}
