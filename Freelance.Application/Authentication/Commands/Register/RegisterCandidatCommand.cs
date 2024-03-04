using Freelance.Application.ViewModels.Authentication;
using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public class RegisterCanidatCommand : IRequest<AuthenticationResponse>
{
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public CandidatCreateDTO? CandidatInfos { get; set; }
    public List<ExperienceCreateDTO>? ExperienceList { get; set; }
    public List<FormationCreateDTO>? FormationList { get; set; }
    public List<ProjetCreateDTO>? ProjetList { get; set; }
    public List<CondidatCompCreateDTO>? CompetenceList { get; set; }
}
