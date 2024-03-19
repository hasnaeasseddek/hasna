
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
    public class OffreRepository : GenericReposAsync<Offre>,IOffreRepository
    {
        #region Feilds
        private readonly DbSet<Offre> _offres;
        #endregion

        #region Constructor
        public OffreRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            _offres = dbContext.Set<Offre>();
        }
        #endregion

        #region Handles Functions
        public async Task<List<Offre>> GetOffresListAsync()
        {
            return await _offres.Include(x=>x.Entreprise).ToListAsync();
        }
        #endregion

    }
}
