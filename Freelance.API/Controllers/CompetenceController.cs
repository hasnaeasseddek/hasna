using Freelance.Application.Services.Condidate.CompetenceService;
using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompetenceController : ControllerBase
{
    private readonly ICompetenceService _competenceService;

    public CompetenceController(ICompetenceService competenceService)
    {
        _competenceService = competenceService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var formationDTO = await _competenceService.FindByIdAsync(id);

        if (formationDTO == null)
        {
            return NotFound();
        }

        return Ok(formationDTO);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var condidatDTO = await _competenceService.FindAllAsync();
        return Ok(condidatDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CompetenceCreateDTO request)
    {
        var createProjetDTO = await _competenceService.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = createProjetDTO.Id }, createProjetDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] CompetenceUpdateDTO updateRequest)
    {
        var updateCondidatDTO = await _competenceService.UpdateAsync(id, updateRequest);

        if (updateCondidatDTO == null)
        {
            return NotFound();
        }

        return Ok(updateCondidatDTO);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _competenceService.DeleteAsync(id);
        return NoContent();
    }
}