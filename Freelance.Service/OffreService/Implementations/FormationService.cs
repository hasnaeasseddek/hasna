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
    public class FormationService : IFormationService
    {
        private readonly IFormationRepository _formationRepository;

        public FormationService(IFormationRepository formationRepository)
        {
            _formationRepository = formationRepository;
        }



        public async Task<List<Formation>> GetFormationsListAsync()
        {
            var formationlist = await _formationRepository.GetTableNoTraking().ToListAsync();
            return formationlist;
        }

        public async Task<Formation> GetFormationsByIDAsync(int id)
        {
            var formation = await _formationRepository.GetTableNoTraking().Where(x => x.Id.Equals(id))
                                       .FirstOrDefaultAsync();
            return formation;
        }



        public async Task<string> AddAsync(Formation formation)
        {
            try
            {
                // Add the new entreprise to the repository
                await _formationRepository.AddAsync(formation);
                return "Success";
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return $"Error adding entreprise: {ex.Message}";
            }
        }



        public async Task<string> EditAsync(Formation formation)
        {
            var existingFormation = _formationRepository.GetTableNoTraking()
                .Where(x => x.Id.Equals(formation.Id))
                .FirstOrDefault();
            if (existingFormation == null)
            {
                return "Projet not found";
            }
            existingFormation.Niveau = formation.Niveau;
            existingFormation.Ecole = formation.Ecole;
            existingFormation.Diplome = formation.Diplome;
            existingFormation.Description = formation.Description;
            existingFormation.Ville = formation.Ville;
            existingFormation.DateDebut = formation.DateDebut;
            existingFormation.DateFin = formation.DateFin;
            await _formationRepository.UpdateAsync(existingFormation);
            return "Success";
        }

        public async Task<string> DeleteAsync(Formation formation)
        {
            await _formationRepository.DeleteAsync(formation);
            return "Success";
        }


    }
}
