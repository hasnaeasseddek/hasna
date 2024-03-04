using Freelance.Application.Services.EntrepriseServices.EntrepriseService;
using Freelance.Application.ViewModels.DTOs.EntrepriseDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EntrepriseController : ControllerBase
{
private readonly IEntrepriseService _entrepriseService;

public EntrepriseController(IEntrepriseService entrepriseService)
{
    _entrepriseService = entrepriseService;
}

[HttpGet("{id}")]
public async Task<IActionResult> GetById(int id)
{
    var formationDTO = await _entrepriseService.FindByIdAsync(id);

    if (formationDTO == null)
    {
        return NotFound();
    }

    return Ok(formationDTO);
}

[HttpGet]
public async Task<IActionResult> GetAll()
{
    var condidatDTO = await _entrepriseService.FindAllAsync();
    return Ok(condidatDTO);
}

[HttpPost]
public async Task<IActionResult> Create([FromBody] EntrepriseCreateDTO request)
{
    var createProjetDTO = await _entrepriseService.CreateAsync(request);
    return CreatedAtAction(nameof(GetById), new { id = createProjetDTO.Id }, createProjetDTO);
}

[HttpPut("{id}")]
public async Task<IActionResult> Update(int id, [FromBody] EntrepriseUpdateDTO updateRequest)
{
    var updateCondidatDTO = await _entrepriseService.UpdateAsync(id, updateRequest);

    if (updateCondidatDTO == null)
    {
        return NotFound();
    }

    return Ok(updateCondidatDTO);
}

[HttpDelete("{id}")]
public async Task<IActionResult> Delete(int id)
{
    await _entrepriseService.DeleteAsync(id);
    return NoContent();
}
}