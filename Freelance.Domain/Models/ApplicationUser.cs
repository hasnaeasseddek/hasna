using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Freelance.Domain.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? CandidatId { get; set; }
    public virtual Candidat? Candidat { get; set; }
    public string? EntrepriseId { get; set; }
    public virtual Entreprise? Entreprise { get; set; }
}
