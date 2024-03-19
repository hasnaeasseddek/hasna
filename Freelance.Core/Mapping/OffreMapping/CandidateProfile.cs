using AutoMapper;
using Freelance.Core.Features.Candidates.Commandes.Models;
using Freelance.Core.Features.Candidates.Queries.Results;
using Freelance.Core.Features.Entreprises.Commandes.Models;
using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Mapping.OffreMapping
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile()
        {
            
                CreateMap<Candidat, GetCandidateListResponse>()
                    .ForMember(dest => dest.FormationsCandidat, opt => opt.MapFrom(src => src.Formations))
                    .ForMember(dest => dest.ExperiencesCandidat, opt => opt.MapFrom(src => src.Experiences))
                    .ForMember(dest => dest.ProjetsCandidat, opt => opt.MapFrom(src => src.Projets));

                CreateMap<Candidat, GetSingleCandidateResponse>()
                    .ForMember(dest => dest.FormationsCandidat, opt => opt.MapFrom(src => src.Formations))
                    .ForMember(dest => dest.ExperiencesCandidat, opt => opt.MapFrom(src => src.Experiences))
                    .ForMember(dest => dest.ProjetsCandidat, opt => opt.MapFrom(src => src.Projets));

                CreateMap<Formation, FormationCandidatRes>(); // For GetCandidateListResponse
                CreateMap<Formation, FormationCandidatRess>(); // For GetSingleCandidateResponse

                CreateMap<Experience, ExperienceCandidatRes>(); // For GetCandidateListResponse
                CreateMap<Experience, ExperienceCandidatRess>(); // For GetSingleCandidateResponse

                CreateMap<Projet, ProjetCandidatRes>(); // For GetCandidateListResponse
                CreateMap<Projet, ProjetCandidatRess>(); // For GetSingleCandidateResponse






            //CreateMap<AddCandidateCommandes, Candidat>()
            //    .ForMember(dest => dest.Formations, opt => opt.MapFrom(src => src.FormationsCandidat))
            //.ForMember(dest => dest.Experiences, opt => opt.MapFrom(src => src.ExperiencesCandidat))
            //.ForMember(dest => dest.Projets, opt => opt.MapFrom(src => src.ProjetsCandidat)); ;
            //CreateMap<Formation, FormationCandidatAdd>(); // For GetCandidateListResponse

            //CreateMap<Experience, ExperienceCandidatAdd>(); // For GetCandidateListResponse

            //CreateMap<Projet, ProjetCandidatAdd>(); // For GetCandidateListResponse


            CreateMap<AddCandidateCommandes, Candidat>()
    .ForMember(dest => dest.Formations, opt => opt.MapFrom(src => src.FormationsCandidat.Select(fc => new Formation
    {
        // Map properties from FormationCandidatAdd to Formation
        Niveau = fc.Niveau,
        Ecole = fc.Ecole,
        Diplome = fc.Diplome,
        Description = fc.Description,
        Ville = fc.Ville,
        DateDebut = fc.DateDebut,
        DateFin = fc.DateFin
    })))
    .ForMember(dest => dest.Experiences, opt => opt.MapFrom(src => src.ExperiencesCandidat.Select(ec => new Experience
    {
        // Map properties from ExperienceCandidatAdd to Experience
        Titre = ec.Titre,
        Local = ec.Local,
        Description = ec.Description,
        Ville = ec.Ville,
        DateDebut = ec.DateDebut,
        DateFin = ec.DateFin
    })))
    .ForMember(dest => dest.Projets, opt => opt.MapFrom(src => src.ProjetsCandidat.Select(pc => new Projet
    {
        // Map properties from ProjetCandidatAdd to Projet
        Nom = pc.Nom,
        Description = pc.Description,
        Link = pc.Link
    })));


            CreateMap<EditCandidateCommandes, Candidat>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Idc));


        }


    }
}
