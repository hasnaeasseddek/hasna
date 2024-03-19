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
    public class FormationRepository : GenericReposAsync<Formation>, IFormationRepository
    {
        private readonly DbSet<Formation> _formations;
        public FormationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _formations = dbContext.Set<Formation>();
        }
    }
}
