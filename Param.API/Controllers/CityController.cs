using Microsoft.AspNetCore.Mvc;
using Param.Application.Features.City.Commands;
using Param.Application.Features.City.Queries;




namespace Param.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var cities = await Mediator.Send(new CityFindAllQuery());
        return Ok(cities);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(int id)
    {
        var city = await Mediator.Send(new CityFindQuery(id));
        return city is null ? NotFound() : Ok(city);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CityCreateCmd cmd)
    {
        var city = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = city.Id }, city);
    }

    [HttpPut]
    public async Task<IActionResult> Update(CityUpdateCmd cmd)
    {
        var city = await Mediator.Send(cmd);
        return Ok(city);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await Mediator.Send(new CityDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}

