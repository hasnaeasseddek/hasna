using Freelance.Infrastructur.Abstracts;
using Freelance.Infrastructur.InfrastructureBases;
using Freelance.Infrastructur.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Freelance.Infrastructur
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IOffreRepository, OffreRepository>();
            services.AddTransient<IEntrepriseRepository, EntrepriseRepository>();
            services.AddTransient<ICandidatRepository, CandidatRepository>();
            services.AddTransient<IFormationRepository, FormationRepository>();
            services.AddTransient<IExperienceRepository, ExperienceRepository>();
            services.AddTransient<IProjetRepository, ProjetRepository>();
            services.AddTransient(typeof(IGenericReposAsync<>),typeof(GenericReposAsync<>));
            return services;
        }
    }
}
