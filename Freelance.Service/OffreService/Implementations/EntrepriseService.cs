using Freelance.Data.Entities;
using Freelance.Infrastructur.Abstracts;
using Freelance.Service.OffreService.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Service.OffreService.Implementations
{
    public class EntrepriseService : IEntrepriseService
    {
        private readonly IEntrepriseRepository _entrepriseRepository;

        public EntrepriseService(IEntrepriseRepository entrepriseRepository)
        {
            _entrepriseRepository = entrepriseRepository;
        }


        public async Task<List<Entreprise>> GetEntreprisesListAsync()
        {
            //return await _entrepriseRepository.GetEntreprisesListAsync();
            var entreplist =  await _entrepriseRepository.GetTableNoTraking().Include(x=>x.Offres).ToListAsync();
            return entreplist;
        }

        public async Task<Entreprise> GetEntreprisesByIDAsync(int id)
        {
            //var entrep = _entrepriseRepository.GetByIdAsync(id);
            var entrep = await _entrepriseRepository.GetTableNoTraking().Where(x=>x.Id.Equals(id))
                                                   .Include(x=>x.Offres)
                                                   .FirstOrDefaultAsync();
            return entrep;
        }


        public async Task<string> AddAsync(Entreprise entreprise)
        {
            try
            {
                // Add the new entreprise to the repository
                await _entrepriseRepository.AddAsync(entreprise);
                return "Success";
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return $"Error adding entreprise: {ex.Message}";
            }

        }

        public async Task<string> EditAsync(Entreprise entreprise)
        {
            var existingEntrep = _entrepriseRepository.GetTableNoTraking()
                .Where(x => x.Id.Equals(entreprise.Id))
                .FirstOrDefault();
            if (existingEntrep == null)
            {
                return "Offre not found";
            }
            existingEntrep.Name=entreprise.Name;
            //existingEntrep.Logo = entreprise.Logo;
            existingEntrep.DateCreation = entreprise.DateCreation;
            existingEntrep.Adresse = entreprise.Adresse;
            existingEntrep.Ville = entreprise.Ville;
            await _entrepriseRepository.UpdateAsync(existingEntrep);
            return "Success";
           
        }
        public async Task<string> DeleteAsync(Entreprise entreprise)
        {
            await _entrepriseRepository.DeleteAsync(entreprise);
            return "Success";
        }

       

        

        
    }
}
