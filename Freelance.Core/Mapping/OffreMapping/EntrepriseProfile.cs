using AutoMapper;
using Freelance.Core.Features.Entreprises.Commandes.Models;
using Freelance.Core.Features.Entreprises.Queries.Results;
using Freelance.Core.Features.Offres.Commandes.Models;
using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Mapping.OffreMapping
{
    public class EntrepriseProfile : Profile
    {
        public EntrepriseProfile()
        {
            CreateMap<Entreprise, GetEntrepriseListResponse>()
               .ForMember(dest => dest.OffreList, opt => opt.MapFrom(src => src.Offres));

            CreateMap<Offre, OffreEntRess>();

            CreateMap<Entreprise, GetSingleEntrepriseResponse>()
                .ForMember(dest => dest.OffreList, opt => opt.MapFrom(src => src.Offres));
            CreateMap<Offre, OffreEntRes>();


            CreateMap<AddEntrepriseCommande, Entreprise>();

            CreateMap<EditEntrepriseCommand, Entreprise>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Ide));
        }
    }
}
