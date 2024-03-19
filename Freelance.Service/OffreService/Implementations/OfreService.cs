
using Freelace.Service.OffreService.Abstracts;
using Freelance.Data.Entities;
using Freelance.Infrastructur.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelace.Service.OffreService.Implementations
{
    public class OfreService : IOffreService
    {
        private readonly IOffreRepository _offreRepository;

        public OfreService(IOffreRepository offreRepository)
        {
            _offreRepository = offreRepository;
        }

       

        public async Task<List<Offre>> GetOffresListAsync()
        {
            return await _offreRepository.GetOffresListAsync();
        }
        public async Task<Offre> GetOffresByIDAsync(int id)
        {
            //var offre = await _offreRepository.GetByIdAsync(id);
            var offre = _offreRepository.GetTableNoTraking()
                                              .Include(x=>x.Entreprise)
                                              .Where(x => x.Id.Equals(id))
                                              .FirstOrDefault();
            return  offre;
        }

        public async Task<string> AddAsync(Offre offre)
        {
            await _offreRepository.AddAsync(offre);
            return "Success";
        }

        public async Task<string> EditAsync(Offre offre)
        {
            //var existingOffre = await _offreRepository.GetByIdAsync(offre.Id);
            var existingOffre = _offreRepository.GetTableNoTraking()
                                             .Include(x => x.Entreprise)
                                             .Where(x => x.Id.Equals(offre.Id))
                                             .FirstOrDefault();

            if (existingOffre == null)
            {
                return "Offre not found";
            }

            // Update only the properties that are specified in the offre
            existingOffre.Titre = offre.Titre;
            existingOffre.Descrpition = offre.Descrpition;
            existingOffre.Date = offre.Date;
            existingOffre.Dure = offre.Dure;
            existingOffre.Adresse = offre.Adresse;
            existingOffre.Ville = offre.Ville;

            await _offreRepository.UpdateAsync(existingOffre);
            return "Success";
        }

        public async Task<string> DeleteAsync(Offre offre)
        {
            await _offreRepository.DeleteAsync(offre);
            return "Success"; 
        }

        public IQueryable<Offre> GetOffresQueryable()
        {
            var offre = _offreRepository.GetTableNoTraking()
                                              .Include(x => x.Entreprise)
                                              .AsQueryable();
            return offre;
        }

        public IQueryable<Offre> FolterOffrePaginaterQuerable(string search)
        {
            var offre = _offreRepository.GetTableNoTraking()
                                              .Include(x => x.Entreprise)
                                              .AsQueryable();
            if (search != null)
            {
                offre = offre.Where(x=>x.Titre.Contains(search) || x.Ville.Contains(search));
            }
            return offre;
        }
    }
}
