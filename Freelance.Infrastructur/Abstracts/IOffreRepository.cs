
using Freelance.Data.Entities;
using Freelance.Infrastructur.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Infrastructur.Abstracts
{
    public interface IOffreRepository : IGenericReposAsync<Offre>
    {
        public Task<List<Offre>> GetOffresListAsync();
    }
}
