using microservice.Auth.Models;
using microservice.Auth.Models.DTO;

namespace microservice.Auth.service.Iservice
{
    public interface IAuthservice
    {
        Task<ResponseDto> Register(RegistrationReqiuestDto registrationReqiuestDto);
        Task<LoginResponceDto> Login(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
