using Microsoft.AspNetCore.Identity;

namespace freelance.Auth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
