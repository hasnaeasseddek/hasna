using Freelance.Application.Services.Condidate.ConsultaionProfilService;
using Freelance.Application.ViewModels.DTOs.ConsultaionProfilDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConsultaionProfilController : ControllerBase
{
    private readonly IConsultaionProfilService _consultaionProfilService;

    public ConsultaionProfilController(IConsultaionProfilService consultaionProfilService)
    {
        _consultaionProfilService = consultaionProfilService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var formationDTO = await _consultaionProfilService.FindByIdAsync(id);

        if (formationDTO == null)
        {
            return NotFound();
        }

        return Ok(formationDTO);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var condidatDTO = await _consultaionProfilService.FindAllAsync();
        return Ok(condidatDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ConsultaionProfilCreateDTO request)
    {
        var createProjetDTO = await _consultaionProfilService.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = createProjetDTO.Id }, createProjetDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] ConsultaionProfilUpdateDTO updateRequest)
    {
        var updateCondidatDTO = await _consultaionProfilService.UpdateAsync(id, updateRequest);

        if (updateCondidatDTO == null)
        {
            return NotFound();
        }

        return Ok(updateCondidatDTO);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _consultaionProfilService.DeleteAsync(id);
        return NoContent();
    }
}
