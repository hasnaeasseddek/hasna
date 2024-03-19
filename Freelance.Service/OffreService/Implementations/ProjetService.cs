using Freelance.Data.Entities;
using Freelance.Infrastructur.Abstracts;
using Freelance.Infrastructur.Repositories;
using Freelance.Service.OffreService.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Service.OffreService.Implementations
{
    public class ProjetService : IProjetService
    {
        private readonly IProjetRepository _projetRepository;

        public ProjetService(IProjetRepository projetRepository)
        {
            _projetRepository = projetRepository;
        }
        public async Task<List<Projet>> GetProjectsListAsync()
        {
            var projetlist = await _projetRepository.GetTableNoTraking().ToListAsync();
            return projetlist;
        }

        public async Task<Projet> GetProjectsByIDAsync(int id)
        {
            var projet = await _projetRepository.GetTableNoTraking().Where(x => x.Id.Equals(id))
                                       .FirstOrDefaultAsync();
            return projet;
        }



        public async Task<string> AddAsync(Projet projet)
        {
            try
            {
                // Add the new entreprise to the repository
                await _projetRepository.AddAsync(projet);
                return "Success";
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return $"Error adding entreprise: {ex.Message}";
            }
        }

       

        public async Task<string> EditAsync(Projet projet)
        {
            var existingProjet= _projetRepository.GetTableNoTraking()
                .Where(x => x.Id.Equals(projet.Id))
                .FirstOrDefault();
            if (existingProjet == null)
            {
                return "Projet not found";
            }
            existingProjet.Nom = projet.Nom;
            existingProjet.Description = projet.Description;
            existingProjet.Link = projet.Link;
            await _projetRepository.UpdateAsync(existingProjet);
            return "Success";
        }

        public async Task<string> DeleteAsync(Projet projet)
        {
            await _projetRepository.DeleteAsync(projet);
            return "Success";
        }



    }
}
