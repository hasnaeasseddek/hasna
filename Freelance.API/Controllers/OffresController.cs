using Freelance.Core.Features.Offres.Queries.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Freelance.Data.AppMetaData;
using Freelance.Core.Features.Offres.Commandes.Models;

namespace Freelance.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class OffresController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OffresController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[HttpGet("/offres/list")]
        [HttpGet(Router.OffreRouting.List)]
        public async Task<IActionResult> GetOffreList()
        {
            var res = await _mediator.Send(new GetOffreListQuery());
            return Ok(res);
        }


        [HttpGet(Router.OffreRouting.Paginated)]
        public async Task<IActionResult> GetOffrePaginated([FromQuery] GetOffrePaginatedListQuery query)
        {
            var res = await _mediator.Send(query);
            return Ok(res);
        }

        //[HttpGet("/offres/{id}")]
        [HttpGet(Router.OffreRouting.GetByID)]
        public async Task<IActionResult> GetOffreById([FromRoute] int id)
        {
            var res = await _mediator.Send(new GetOffreByIDQuery(id));
            return Ok(res);
        }
        //[HttpGet("/offres/{id}")]
        [HttpPost(Router.OffreRouting.Create)]
        public async Task<IActionResult> CreateOffre([FromBody] AddOffreCommand command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }

        //[HttpGet("/offres/{id}")]
        [HttpPut(Router.OffreRouting.Edit)]
        public async Task<IActionResult> EditOffre([FromBody] EditOffreCommand command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }

        [HttpDelete(Router.OffreRouting.Delete)]
        public async Task<IActionResult> DeleteOffre([FromRoute] int id)
        {
            var res = await _mediator.Send(new DeleteOffreCommande(id));
            return Ok(res);
        }
    }
}
