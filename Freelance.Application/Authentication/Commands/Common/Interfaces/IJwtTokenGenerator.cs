
using Freelance.Application.ViewModels.Authentication;
using Freelance.Domain.Models;

namespace Freelance.Application.Authentication.Common.Interfaces;

public interface IJwtTokenGenerator
{
    Task<string> GenerateToken(GenerateTokenParams Tokenparams);
}
