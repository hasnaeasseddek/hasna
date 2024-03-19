using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Service.OffreService.Abstracts
{
    public interface IProjetService
    {
        public Task<List<Projet>> GetProjectsListAsync();
        public Task<Projet> GetProjectsByIDAsync(int id);
        public Task<string> AddAsync(Projet projet);
        public Task<string> EditAsync(Projet projet);
        public Task<string> DeleteAsync(Projet projet);
    }
}
