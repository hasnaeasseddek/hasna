using Freelance.Application.Services.Condidate.MessagerieService;
using Freelance.Application.ViewModels.DTOs.MessagerieDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers;



[Route("api/[controller]")]
[ApiController]
public class MessagerieController : ControllerBase
{
    private readonly IMessagerieService _messageriService;

    public MessagerieController(IMessagerieService messageriService)
    {
        _messageriService = messageriService;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var formationDTO = await _messageriService.FindByIdAsync(id);

        if (formationDTO == null)
        {
            return NotFound();
        }

        return Ok(formationDTO);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var condidatDTO = await _messageriService.FindAllAsync();
        return Ok(condidatDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] MessagerieCreateDTO request)
    {
        var createProjetDTO = await _messageriService.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = createProjetDTO.Id }, createProjetDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] MessagerieUpdateDTO updateRequest)
    {
        var updateCondidatDTO = await _messageriService.UpdateAsync(id, updateRequest);

        if (updateCondidatDTO == null)
        {
            return NotFound();
        }

        return Ok(updateCondidatDTO);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _messageriService.DeleteAsync(id);
        return NoContent();
    }
}
