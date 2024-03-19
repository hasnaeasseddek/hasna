using Freelance.Core.Features.Entreprises.Commandes.Models;
using Freelance.Core.Features.Entreprises.Queries.Models;
using Freelance.Core.Features.Formations.Commandes.Models;
using Freelance.Core.Features.Formations.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FormationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/formations/list")]
        public async Task<IActionResult> GetFormationList()
        {
            var res = await _mediator.Send(new GetFormationListQuery());
            return Ok(res);
        }

        [HttpGet("/formations/{id}")]
        public async Task<IActionResult> GetFormationById([FromRoute] int id)
        {
            var res = await _mediator.Send(new GetFormationByIDQuery(id));
            return Ok(res);
        }




        [HttpPost("/formations/create")]
        public async Task<IActionResult> AddFormation([FromBody] AddFormationCommandes addFormationCommandes)
        {
            var result = await _mediator.Send(addFormationCommandes);
            return Ok(result);

        }

        [HttpPut("/formation/edit")]
        public async Task<IActionResult> EditEntreprise([FromBody] EditFormationCommandes editFormationCommandes)
        {
            var res = await _mediator.Send(editFormationCommandes);
            return Ok(res);
        }

        [HttpDelete("/formation/{id}")]
        public async Task<IActionResult> DeleteEntreprise([FromRoute] int id)
        {
            var res = await _mediator.Send(new DeleteFormationCommandes(id));
            return Ok(res);
        }
    }
}
