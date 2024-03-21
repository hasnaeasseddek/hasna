using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelace.Service.OffreService.Abstracts
{
    public interface IOffreService
    {
        public Task<List<Offre>> GetOffresListAsync();
        public Task<List<Offre>> GetLatesttOffresAsync();
        public Task<Offre> GetOffresByIDAsync(int id);
        public Task<string> AddAsync(Offre offre);
        public Task<string> EditAsync(Offre offre);
        public Task<string> DeleteAsync(Offre offre);

        public IQueryable<Offre> GetOffresQueryable();
        public IQueryable<Offre> FolterOffrePaginaterQuerable(string search);

    }
}
