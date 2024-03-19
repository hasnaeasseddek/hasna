using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Service.OffreService.Abstracts
{
    public interface IEntrepriseService
    {
        public Task<List<Entreprise>> GetEntreprisesListAsync();
        public Task<Entreprise> GetEntreprisesByIDAsync(int id);
        public Task<string> AddAsync(Entreprise entreprise);
        public Task<string> EditAsync(Entreprise entreprise);
        public Task<string> DeleteAsync(Entreprise entreprise);
    }
}
