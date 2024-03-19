using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Service.OffreService.Abstracts
{
    public interface ICandidatService
    {
        public Task<List<Candidat>> GetCandidatsListAsync();
        public Task<Candidat> GetCandidatsByIDAsync(int id);
        public Task<string> AddAsync(Candidat candidat);
        public Task<string> EditAsync(Candidat candidat);
        public Task<string> DeleteAsync(Candidat candidat);
    }
}
