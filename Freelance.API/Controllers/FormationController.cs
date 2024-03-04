using Freelance.Application.Services.Condidate.CandidatService;
using Freelance.Application.Services.Condidate.FormationService;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class FormationController : ControllerBase
{
    private readonly IFormationService _formationService;

    public FormationController(IFormationService formationService)
    {
        _formationService = formationService;
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var formationDTO = await _formationService.FindByIdAsync(id);

        if (formationDTO == null)
        {
            return NotFound();
        }

        return Ok(formationDTO);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var condidatDTO = await _formationService.FindAllAsync();
        return Ok(condidatDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]  FormationCreateDTO request)
    {
        var createCondidatDTO = await _formationService.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = createCondidatDTO.Id }, createCondidatDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] FormationUpdateDTO updateRequest)
    {
        var updateCondidatDTO = await _formationService.UpdateAsync(id, updateRequest);

        if (updateCondidatDTO == null)
        {
            return NotFound();
        }

        return Ok(updateCondidatDTO);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _formationService.DeleteAsync(id);
        return NoContent();
    }
}
