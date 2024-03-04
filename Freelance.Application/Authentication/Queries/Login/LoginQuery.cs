using Freelance.Application.ViewModels.Authentication;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Freelance.Application.Authentication.Queries.Login;

public record LoginQuery(
    [Required]
    string Email,
    [Required]
    string Password
    ) : IRequest<AuthenticationResponse>;
