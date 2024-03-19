using Freelace.Service.OffreService.Abstracts;
using Freelace.Service.OffreService.Implementations;
using Freelance.Service.OffreService.Abstracts;
using Freelance.Service.OffreService.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Freelance.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddModuleServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IOffreService, OfreService>();
            services.AddTransient<IEntrepriseService, EntrepriseService>();
            services.AddTransient<ICandidatService, CandidatService>();
            services.AddTransient<IFormationService, FormationService>();
            services.AddTransient<IExperienceService, ExperienceService>();
            services.AddTransient<IProjetService, ProjetService>();
            return services;
        }
    }
}
