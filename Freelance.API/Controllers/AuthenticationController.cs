using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.Authentication.Queries.Login;
using Freelance.Application.ViewModels.Authentication;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly ISender _mediator;

    public AuthenticationController(ISender mediator)
    {
        _mediator = mediator;
    }


    [HttpPost("registerCandidat")]
    public async Task<ActionResult> RegisterCandidat(RegisterCanidatCommand command)
    {
        // attributs validation
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }


        var response = await _mediator.Send(command);

        if (!response.ISAuthenticated)
        {
            return BadRequest(response.Message);
        }


        return Ok(response);
    }

    [HttpPost("registerEntreprise")]
    public async Task<ActionResult> RegisterEntrprise(RegisterEnrepriseCommand command)
    {
        // attributs validation
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }


        var response = await _mediator.Send(command);

        if (!response.ISAuthenticated)
        {
            return BadRequest(response.Message);
        }


        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginQuery request)
    {
        // attributs validation
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var response = await _mediator.Send(request);

        if (!response.ISAuthenticated)
        {
            return BadRequest(response.Message);
        }

        return Ok(response);
    }
}
