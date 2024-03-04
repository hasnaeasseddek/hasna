using Freelance.Application.Authentication.Common.Interfaces;
using Freelance.Application.Services.Authentication;
using Freelance.Application.ViewModels.Authentication;
using MediatR;

namespace Freelance.Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, AuthenticationResponse>
{
    private readonly IAuthenticationService _authenticationservice;

    public LoginQueryHandler(
        IAuthenticationService authenticationservice
        )
    {
        _authenticationservice = authenticationservice;
    }

    public Task<AuthenticationResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var loginResult = _authenticationservice.Login( request );

        return loginResult;
    }
}
