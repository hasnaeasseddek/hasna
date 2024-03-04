using Freelance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Persistence.IRepositories;

public interface ICondidatRepository
{
    Task<Candidat> GetCandidatWithDetailsAsync(int candidatId);
    Task<List<Candidat>> GetAllCandidatsWithDetailsAsync();
}
