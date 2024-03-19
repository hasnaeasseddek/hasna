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
    public class CandidatRepository : GenericReposAsync<Candidat>, ICandidatRepository
    {
        private readonly DbSet<Candidat> _candidates;
        public CandidatRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _candidates = dbContext.Set<Candidat>();
        }
    }
}
