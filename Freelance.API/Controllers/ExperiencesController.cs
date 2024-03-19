using Freelance.Core.Features.Experiences.Commandes.Models;
using Freelance.Core.Features.Experiences.Queries.Models;
using Freelance.Core.Features.Formations.Commandes.Models;
using Freelance.Core.Features.Formations.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExperiencesController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet("/experience/list")]
        public async Task<IActionResult> GetExperienceList()
        {
            var res = await _mediator.Send(new GetExperienceListQuery());
            return Ok(res);
        }

        [HttpGet("/experience/{id}")]
        public async Task<IActionResult> GetExperienceById([FromRoute] int id)
        {
            var res = await _mediator.Send(new GetExperienceByIDQuery(id));
            return Ok(res);
        }




        [HttpPost("/experience/create")]
        public async Task<IActionResult> AddExperience([FromBody] AddExperienceCommandes addExperienceCommandes)
        {
            var result = await _mediator.Send(addExperienceCommandes);
            return Ok(result);

        }

        [HttpPut("/experience/edit")]
        public async Task<IActionResult> EditExperience([FromBody] EditExperienceCommandes editExperienceCommandes)
        {
            var res = await _mediator.Send(editExperienceCommandes);
            return Ok(res);
        }

        [HttpDelete("/experience/{id}")]
        public async Task<IActionResult> DeleteExperience([FromRoute] int id)
        {
            var res = await _mediator.Send(new DeleteExperienceCommandes(id));
            return Ok(res);
        }
    }
}
