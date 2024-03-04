using Freelance.Application.Persistence.IRepositories;
using Freelance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Freelance.Infrastructure.Persistence.Repositories.CondidateRepository;

namespace Freelance.Infrastructure.Persistence.Repositories;

internal class CondidateRepository : ICondidatRepository
{
    private readonly ApplicationDbContext _db;

    public CondidateRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<Candidat> GetCandidatWithDetailsAsync(int candidatId)
    {
        return await _db.Set<Candidat>()
            .Include(c => c.Formations)
            .Include(c => c.Experiences)
            .Include(c => c.Projets)
            .Include(c => c.CondidatComps)
            .Where(c => c.Id == candidatId)
            .FirstOrDefaultAsync();
    }

    public async Task<List<Candidat>> GetAllCandidatsWithDetailsAsync()
    {
        var candidats = await _db.Set<Candidat>()
            .Include(c => c.CondidatComps)
            .Include(c => c.Experiences)
            .Include(c => c.Formations)
            .Include(c => c.Projets)
            // Include other related entities as needed
            .ToListAsync();

        return candidats;
    }

}

