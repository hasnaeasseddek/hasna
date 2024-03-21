using microservice.Auth.Models;

namespace microservice.Auth.service.Iservice
{
    public interface Itest
    {
        public string generateToken(ApplicationUser applicationuser);
    }
}
