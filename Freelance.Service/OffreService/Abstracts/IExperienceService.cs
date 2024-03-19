using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Service.OffreService.Abstracts
{
    public interface IExperienceService
    {
        public Task<List<Experience>> GetExperiencesListAsync();
        public Task<Experience> GetExperiencesByIDAsync(int id);
        public Task<string> AddAsync(Experience experience);
        public Task<string> EditAsync(Experience experience);
        public Task<string> DeleteAsync(Experience experience);
    }
}
