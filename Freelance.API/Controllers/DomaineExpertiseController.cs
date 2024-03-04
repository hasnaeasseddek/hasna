using Freelance.Application.Services.Condidate.DomaineExpertiseService;
using Freelance.Application.ViewModels.DTOs.DomaineExpertise;
using Freelance.Application.ViewModels.DTOs.OffreDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DomaineExpertiseController : ControllerBase
{

    private readonly IDomaineExpertiseService  _domaineExpertiseService;

    public DomaineExpertiseController(IDomaineExpertiseService domaineExpertiseService)
    {
        _domaineExpertiseService = domaineExpertiseService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var formationDTO = await _domaineExpertiseService.FindByIdAsync(id);

        if (formationDTO == null)
        {
            return NotFound();
        }

        return Ok(formationDTO);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var condidatDTO = await _domaineExpertiseService.FindAllAsync();
        return Ok(condidatDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] DomaineExpertiseCreateDTO request)
    {
        var createDTO = await _domaineExpertiseService.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = createDTO.Id }, createDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] DomaineExpertiseUpdateDTO updateRequest)
    {
        var updateDTO = await _domaineExpertiseService.UpdateAsync(id, updateRequest);

        if (updateDTO == null)
        {
            return NotFound();
        }

        return Ok(updateDTO);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _domaineExpertiseService.DeleteAsync(id);
        return NoContent();
    }
}
