using Freelance.Core.Features.Candidates.Commandes.Models;
using Freelance.Core.Features.Candidates.Queries.Models;
using Freelance.Core.Features.Entreprises.Commandes.Models;
using Freelance.Core.Features.Entreprises.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CandidatesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("/candidates/list")]
        public async Task<IActionResult> GetCandidateList()
        {
            var res = await _mediator.Send(new GetCandidateListQuery());
            return Ok(res);
        }

        [HttpGet("/candidates/{id}")]
        public async Task<IActionResult> GetCandidateById([FromRoute] int id)
        {
            var res = await _mediator.Send(new GetCandidateByIDQuery(id));
            return Ok(res);
        }





        [HttpPost("/candidate/create")]
        public async Task<IActionResult> AddCandidate([FromBody] AddCandidateCommandes addCandidateCommandes)
        {
            var result = await _mediator.Send(addCandidateCommandes);
            return Ok(result);

        }

        [HttpPut("/candidate/edit")]
        public async Task<IActionResult> EditCandidate([FromBody] EditCandidateCommandes editCandidateCommandes)
        {
            var res = await _mediator.Send(editCandidateCommandes);
            return Ok(res);
        }

        [HttpDelete("/candidate/delete/{id}")]
        public async Task<IActionResult> DeleteCandidate([FromRoute] int id)
        {
            var res = await _mediator.Send(new DeleteCandidateCommandes(id));
            return Ok(res);
        }
    }
}
