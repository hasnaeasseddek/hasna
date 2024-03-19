using Freelance.Data.Entities;
using Freelance.Infrastructur.Abstracts;
using Freelance.Infrastructur.InfrastructureBases;
using Freelance.InfrastructurData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Infrastructur.Repositories
{

    public class EntrepriseRepository : GenericReposAsync<Entreprise>, IEntrepriseRepository
    {

        private readonly DbSet<Entreprise> _entreprises;
        public EntrepriseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _entreprises = dbContext.Set<Entreprise>();
        }

        //public async Task<List<Entreprise>> GetEntreprisesListAsync()
        //{
        //    return await _entreprises.Include(x => x.Offres).ToListAsync();
        //}
    }
}
