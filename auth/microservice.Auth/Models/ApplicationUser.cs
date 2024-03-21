using Microsoft.AspNetCore.Identity;

namespace microservice.Auth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
