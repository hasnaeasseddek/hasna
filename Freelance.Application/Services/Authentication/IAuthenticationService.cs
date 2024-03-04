using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.Authentication.Queries.Login;
using Freelance.Application.ViewModels.Authentication;

namespace Freelance.Application.Services.Authentication;

public interface IAuthenticationService
{
    Task<AuthenticationResponse> RegisterEntreprise(RegisterEnrepriseCommand command);
    Task<AuthenticationResponse> RegisterCandidat(RegisterCanidatCommand command);
    Task<AuthenticationResponse> Login(LoginQuery query);

}
