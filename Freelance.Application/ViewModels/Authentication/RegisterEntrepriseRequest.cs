using System.ComponentModel.DataAnnotations;

namespace Freelance.Application.ViewModels.Authentication;

public record RegisterEntrepriseRequest(
        
        [Required]
        string Email,
        [Required]
        string Password
    );

