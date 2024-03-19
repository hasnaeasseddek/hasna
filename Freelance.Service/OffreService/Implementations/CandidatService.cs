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
    public class CandidatService : ICandidatService
    {
        private readonly ICandidatRepository _candidatRepository;
        public CandidatService(ICandidatRepository candidatRepository)
        {
            _candidatRepository = candidatRepository;
        }


        public async Task<List<Candidat>> GetCandidatsListAsync()
        {
            var candidatlist = await _candidatRepository.GetTableNoTraking()
                .Include(x=>x.Formations)
                .Include(x=>x.Experiences)
                .Include(x=>x.Projets)
                .ToListAsync();
            return candidatlist;
        }


        public async Task<Candidat> GetCandidatsByIDAsync(int id)
        {
            var candid = await _candidatRepository.GetTableNoTraking().Where(x => x.Id.Equals(id))
                .Include(x => x.Formations)
                .Include(x => x.Experiences)
                .Include(x => x.Projets)
                .FirstOrDefaultAsync();
            return candid;
        }


        public async Task<string> AddAsync(Candidat candidat)
        {
            try
            {
                // Add the new entreprise to the repository
                await _candidatRepository.AddAsync(candidat);
                return "Success";
            }
            catch (Exception ex)
            {
                // Handle exception appropriately
                return $"Error adding entreprise: {ex.Message}";
            }
        }


        public async Task<string> EditAsync(Candidat candidat)
        {
            var existingcandidat = _candidatRepository.GetTableNoTraking()
               .Where(x => x.Id.Equals(candidat.Id))
               .FirstOrDefault();
            if (existingcandidat == null)
            {
                return "Offre not found";
            }

            existingcandidat.FirstName = candidat.FirstName;
            existingcandidat.LastName = candidat.LastName;
            existingcandidat.Email = candidat.Email;
            existingcandidat.Tele = candidat.Tele;
            existingcandidat.GitHub = candidat.GitHub;
            existingcandidat.LinkedIn = candidat.LinkedIn;
            existingcandidat.Titre = candidat.Titre;
            existingcandidat.Gender = candidat.Gender;
            //existingcandidat.Avatar = candidat.Avatar;
            existingcandidat.Adresse = candidat.Adresse;
            existingcandidat.DateNaissance = candidat.DateNaissance;
            existingcandidat.Mobilite = candidat.Mobilite;
            existingcandidat.Disponibilite = candidat.Disponibilite;
            existingcandidat.Ville = candidat.Ville;

            await _candidatRepository.UpdateAsync(existingcandidat);
            return "Success";
        }


        public async Task<string> DeleteAsync(Candidat candidat)
        {
            await _candidatRepository.DeleteAsync(candidat);
            return "Success";
        }

        

        

        
    }
}
