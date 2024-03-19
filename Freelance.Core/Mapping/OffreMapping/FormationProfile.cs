using AutoMapper;
using Freelance.Core.Features.Entreprises.Commandes.Models;
using Freelance.Core.Features.Formations.Commandes.Models;
using Freelance.Core.Features.Formations.Queries.Results;
using Freelance.Core.Features.Offres.Queries.Results;
using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Mapping.OffreMapping
{
    public class FormationProfile : Profile
    {
        public FormationProfile()
        {
            CreateMap<Formation, GetFormationListResponse>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Formation, GetSingleFormationResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<AddFormationCommandes, Formation>();

            CreateMap<EditFormationCommandes, Formation>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Idf));

        }
    }
}
