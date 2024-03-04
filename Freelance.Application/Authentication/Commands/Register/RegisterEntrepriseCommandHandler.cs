using Freelance.Application.Services.Authentication;
using Freelance.Application.ViewModels.Authentication;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public class RegisterEntrepriseCommandHandler : IRequestHandler<RegisterEnrepriseCommand, AuthenticationResponse>
{
    private readonly IAuthenticationService _authenticationservice;

    public RegisterEntrepriseCommandHandler(IAuthenticationService authenticationService)
    {
        _authenticationservice = authenticationService;
    }

    public async Task<AuthenticationResponse> Handle(RegisterEnrepriseCommand command, CancellationToken cancellationToken)
    {
        var registerResult = await _authenticationservice.RegisterEntreprise(command);

        return registerResult;
    }
}
