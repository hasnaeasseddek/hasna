using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Service.OffreService.Abstracts
{
    public interface IFormationService
    {
        public Task<List<Formation>> GetFormationsListAsync();
        public Task<Formation> GetFormationsByIDAsync(int id);
        public Task<string> AddAsync(Formation formation);
        public Task<string> EditAsync(Formation formation);
        public Task<string> DeleteAsync(Formation formation);
    }
}
