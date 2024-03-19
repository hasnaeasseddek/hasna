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
    public class ProjetRepository : GenericReposAsync<Projet>, IProjetRepository
    {
        private readonly DbSet<Projet> _projets;
        public ProjetRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _projets = dbContext.Set<Projet>();
        }
    }
}
