using MediatR;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Freelance.Application.Services.Authentication;
using Freelance.Application.Services.Condidate.CandidatService;
using Freelance.Application.Common.Mapping;
using Freelance.Application.Services.Condidate.CompetenceOffreService;
using Freelance.Application.Services.Condidate.OffreService;
using Freelance.Application.Services.Condidate.CompetenceService;
using Freelance.Application.Services.Condidate.ExperienceService;
using Freelance.Application.Services.Condidate.ComptenceDmExpertiseService;
using Freelance.Application.Services.Condidate.CondidatCompService;
using Freelance.Application.Services.Condidate.ConsultaionProfilService;
using Freelance.Application.Services.Condidate.DomaineExpertiseService;
using Freelance.Application.Services.EntrepriseServices.EntrepriseService;
using Freelance.Application.Services.Condidate.FormationService;
using Freelance.Application.Services.Condidate.ProjetService;
using Freelance.Application.Persistence.IRepositories;

namespace Freelance.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);

        services.AddAutoMapper(typeof(MappingProfile));

        services.AddScoped<IMapper, Mapper>();

        services.AddScoped<IAuthenticationService, AuthenticationService>();

        //services

        services.AddScoped<ICandidateService, CandidatService>();
        services.AddScoped<ICompetenceService, CompetenceService>();
        services.AddScoped<ICompetenceOffreSevice, CompetenceOffreService>();
        services.AddScoped<IComptenceDmExpertiseService, ComptenceDmExpertiseService>();
        services.AddScoped<ICondidatCompService, CondidatCompService>();
        services.AddScoped<IConsultaionProfilService, ConsultaionProfilService>();
        services.AddScoped<IDomaineExpertiseService, DomaineExpertiseService>();
        services.AddScoped<IEntrepriseService, EntrepriseService>();
        services.AddScoped<IExperienceService, ExperienceService>();
        services.AddScoped<IFormationService, FormationService>();
        services.AddScoped<IOffreService, OffreService>();
        services.AddScoped<IProjetService, ProjetService>();




        return services;
    }
}
