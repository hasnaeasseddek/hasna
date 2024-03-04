using AutoMapper;
using Freelance.Domain.Models;
using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;
using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Application.ViewModels.DTOs.CompetenceOffreDTO;
using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ConsultaionProfilDTO;
using Freelance.Application.ViewModels.DTOs.DomaineExpertise;
using Freelance.Application.ViewModels.DTOs.EntrepriseDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.ViewModels.DTOs.MessagerieDTO;
using Freelance.Application.ViewModels.DTOs.OffreDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using System;

namespace Freelance.Application.Common.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // CompitenceDmExpertise
        CreateMap<ComptenceDmExpertise, ComptenceDmExpertiseDTO>().ReverseMap();
        CreateMap<ComptenceDmExpertise, ComptenceDmExpertiseUpdateDTO>().ReverseMap();
        CreateMap<ComptenceDmExpertise, ComptenceDmExpertiseCreateDTO>().ReverseMap();

        // Competence
        CreateMap<Competence, CompetenceDTO>().ReverseMap();
        CreateMap<Competence, CompetenceUpdateDTO>().ReverseMap();
        CreateMap<Competence, CompetenceCreateDTO>().ReverseMap();

        //CompitenceOffer
        CreateMap<CompetenceOffre, CompetenceOffreDTO>().ReverseMap();
        CreateMap<CompetenceOffre, CompetenceOffreUpdateDTO>().ReverseMap();
        CreateMap<CompetenceOffre, CompetenceOffreCreateDTO>().ReverseMap();

        //CondidatComp
        CreateMap<CondidatComp, CondidatCompGetDTO>().ReverseMap();
        CreateMap<CondidatComp, CondidatCompUpdateDTO>().ReverseMap();
        CreateMap<CondidatComp, CondidatCompCreateDTO>().ReverseMap();

        // Condidat
        CreateMap<Candidat, CandidatDTO>().ReverseMap();
        CreateMap<Candidat, CandidatUpdateDTO>().ReverseMap();
        CreateMap<Candidat, CandidatCreateDTO>().ReverseMap();

        //ConsultationProfile
        CreateMap<ConsultaionProfil, ConsultaionProfilDTO>().ReverseMap();
        CreateMap<ConsultaionProfil, ConsultaionProfilUpdateDTO>().ReverseMap();
        CreateMap<ConsultaionProfil, ConsultaionProfilCreateDTO>().ReverseMap();

        //DomaineExpertise
        CreateMap<DomaineExpertise, DomaineExpertiseDTO>().ReverseMap();
        CreateMap<DomaineExpertise, DomaineExpertiseUpdateDTO>().ReverseMap();
        CreateMap<DomaineExpertise, DomaineExpertiseCreateDTO>().ReverseMap();

        //Entreprise
        CreateMap<Entreprise, EntrepriseDTO>().ReverseMap();
        CreateMap<Entreprise, EntrepriseUpdateDTO>().ReverseMap();
        CreateMap<Entreprise, EntrepriseCreateDTO>().ReverseMap();

        // Experience
        CreateMap<Experience, ExperienceGetDTO>().ReverseMap();
        CreateMap<Experience, ExperienceUpdateDTO>().ReverseMap();
        CreateMap<Experience, ExperienceCreateDTO>().ReverseMap();

        // Formation
        CreateMap<Formation, FormationGetDTO>().ReverseMap();
        CreateMap<Formation, FormationUpdateDTO>().ReverseMap();
        CreateMap<Formation, FormationCreateDTO>().ReverseMap();

        // Messagerie
        CreateMap<Messagerie, MessagerieDTO>().ReverseMap();
        CreateMap<Messagerie, MessagerieUpdateDTO>().ReverseMap();
        CreateMap<Messagerie, MessagerieCreateDTO>().ReverseMap();

        // Offre
        CreateMap<Offre, OffreDTO>().ReverseMap();
        CreateMap<Offre, OffreUpdateDTO>().ReverseMap();
        CreateMap<Offre, OffreCreateDTO>().ReverseMap();

        // Projet
        CreateMap<Projet, ProjetGetDTO>().ReverseMap();
        CreateMap<Projet, ProjetUpdateDTO>().ReverseMap();
        CreateMap<Projet, ProjetCreateDTO>().ReverseMap();
    }
}
