using Freelance.Core.Features.Entreprises.Commandes.Models;
using Freelance.Core.Features.Entreprises.Queries.Models;
using Freelance.Core.Features.Offres.Commandes.Models;
using Freelance.Core.Features.Offres.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntreprisesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EntreprisesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/entreprises/list")]
        public async Task<IActionResult> GetEntrepriseList()
        {
            var res = await _mediator.Send(new GetEntrepriseListQuery());
            return Ok(res);
        }

        [HttpGet("/entreprises/{id}")]
        public async Task<IActionResult> GetEntrepriseById([FromRoute] int id)
        {
            var res = await _mediator.Send(new GetEntrepriseByIDQuery(id));
            return Ok(res);
        }




        [HttpPost]
        public async Task<IActionResult> AddEntreprise([FromBody] AddEntrepriseCommande addEntrepriseCommande)
        {
                var result = await _mediator.Send(addEntrepriseCommande);
                return Ok(result);

        }

        [HttpPut("/entreprises/edit")]
        public async Task<IActionResult> EditEntreprise([FromBody] EditEntrepriseCommand editEntrepriseCommand)
        {
            var res = await _mediator.Send(editEntrepriseCommand);
            return Ok(res);
        }

        [HttpDelete("/entreprises/{id}")]
        public async Task<IActionResult> DeleteEntreprise([FromRoute] int id)
        {
            var res = await _mediator.Send(new DeleteEntrepriseCommande(id));
            return Ok(res);
        }



    }
}
