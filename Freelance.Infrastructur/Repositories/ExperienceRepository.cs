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
    public class ExperienceRepository : GenericReposAsync<Experience>, IExperienceRepository
    {
        private readonly DbSet<Experience> _experiences;

        public ExperienceRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _experiences = dbContext.Set<Experience>();
        }
    }
}
