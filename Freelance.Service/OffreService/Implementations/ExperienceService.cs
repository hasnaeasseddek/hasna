using Freelance.Data.Entities;
using Freelance.Infrastructur.Abstracts;
using Freelance.Infrastructur.Repositories;
using Freelance.Service.OffreService.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Service.OffreService.Implementations
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;
        public ExperienceService(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }


        public async Task<List<Experience>> GetExperiencesListAsync()
        {
            var experiencelist = await _experienceRepository.GetTableNoTraking().ToListAsync();
            return experiencelist;
        }
        
        public async Task<Experience> GetExperiencesByIDAsync(int id)
        {
            var experience = await _experienceRepository.GetTableNoTraking().Where(x => x.Id.Equals(id))
                                       .FirstOrDefaultAsync();
            return experience;
        }

        public async Task<string> AddAsync(Experience experience)
        {
            try
            {
                // Add the new entreprise to the repository
                await _experienceRepository.AddAsync(experience);
                return "Success";
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return $"Error adding entreprise: {ex.Message}";
            }
        }
        public async Task<string> EditAsync(Experience experience)
        {
            var existingExperience = _experienceRepository.GetTableNoTraking()
                .Where(x => x.Id.Equals(experience.Id))
                .FirstOrDefault();
            if (existingExperience == null)
            {
                return "Projet not found";
            }
            existingExperience.Titre = experience.Titre;
            existingExperience.Local = experience.Local;
            existingExperience.Description = experience.Description;
            existingExperience.Ville = experience.Ville;
            existingExperience.DateDebut = experience.DateDebut;
            existingExperience.DateFin = experience.DateFin;
            await _experienceRepository.UpdateAsync(existingExperience);
            return "Success";
        }

        public async Task<string> DeleteAsync(Experience experience)
        {
            await _experienceRepository.DeleteAsync(experience);
            return "Success";
        }

        

        

        
    }
}
