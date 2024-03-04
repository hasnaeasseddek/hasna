using Freelance.Application.Services.Authentication;
using Freelance.Application.ViewModels.Authentication;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public class RegisterCandidatCommandHandler : IRequestHandler<RegisterCanidatCommand, AuthenticationResponse>
{
    private readonly IAuthenticationService _authenticationservice;

    public RegisterCandidatCommandHandler(IAuthenticationService authenticationService)
    {
        _authenticationservice = authenticationService;
    }
    public async Task<AuthenticationResponse> Handle(RegisterCanidatCommand request, CancellationToken cancellationToken)
    {
        var result = await _authenticationservice.RegisterCandidat(request);

        return result;
    }
}
