using Freelance.Application.ViewModels.Authentication;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public record RegisterEnrepriseCommand(
    string EntrepriseName,
    string Email,
    string Password
    ) : IRequest<AuthenticationResponse>;
