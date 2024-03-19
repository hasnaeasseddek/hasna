using AutoMapper;
using Freelance.Core.Features.Offres.Commandes.Models;
using Freelance.Core.Features.Offres.Queries.Results;
using Freelance.Data.Entities;


namespace Freelance.Core.Mapping.OffreMapping
{
    public class OffreProfile : Profile
    {
        public OffreProfile()
        {
            CreateMap<Offre, GetOffreListResponse>()
                .ForMember(dest => dest.EntrepriseName, opt => opt.MapFrom(src => src.Entreprise.Name));
            CreateMap<Offre, GetSingleOffreResponse>()
                .ForMember(dest => dest.EntrepriseName, opt => opt.MapFrom(src => src.Entreprise.Name));


            CreateMap<AddOffreCommand, Offre>()
                .ForMember(dest => dest.IdEntreprise, opt => opt.MapFrom(src => src.Entreprise_ID));

            CreateMap<EditOffreCommand, Offre>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Ido));
                //.ForMember(dest => dest.Id, opt => opt.Ignore());



        }
    }
}
