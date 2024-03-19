using Freelance.Core.Features.Formations.Commandes.Models;
using Freelance.Core.Features.Formations.Queries.Models;
using Freelance.Core.Features.Projets.Commandes.Models;
using Freelance.Core.Features.Projets.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjetsController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet("/project/list")]
        public async Task<IActionResult> GetProjetList()
        {
            var res = await _mediator.Send(new GetProjetListQuery());
            return Ok(res);
        }

        [HttpGet("/project/{id}")]
        public async Task<IActionResult> GetProjetById([FromRoute] int id)
        {
            var res = await _mediator.Send(new GetProjetByIDQuery(id));
            return Ok(res);
        }




        [HttpPost("/project/create")]
        public async Task<IActionResult> AddProjet([FromBody] AddProjetCommandes addProjetCommandes)
        {
            var result = await _mediator.Send(addProjetCommandes);
            return Ok(result);

        }

        [HttpPut("/project/edit")]
        public async Task<IActionResult> EditProjet([FromBody] EditProjetCommandes editProjetCommandes)
        {
            var res = await _mediator.Send(editProjetCommandes);
            return Ok(res);
        }

        [HttpDelete("/project/{id}")]
        public async Task<IActionResult> DeleteProjet([FromRoute] int id)
        {
            var res = await _mediator.Send(new DeleteProjetCommandes(id));
            return Ok(res);
        }
    }
}
