using freelance.Auth.Models;
using freelance.Auth.Models.DTO;

namespace freelance.Auth.service.Iservice
{
    public interface IAuthservice
    {
        Task<ResponseDto> Register(RegistrationReqiuestDto registrationReqiuestDto);
        Task<LoginResponceDto> Login(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
