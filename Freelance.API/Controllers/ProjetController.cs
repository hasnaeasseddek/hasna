using Freelance.Application.Services.Condidate.FormationService;
using Freelance.Application.Services.Condidate.ProjetService;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ProjetController : ControllerBase
    {
        private readonly IProjetService _projetService;

        public ProjetController(IProjetService projetService)
        {
            _projetService = projetService;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var formationDTO = await _projetService.FindByIdAsync(id);

            if (formationDTO == null)
            {
                return NotFound();
            }

            return Ok(formationDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var condidatDTO = await _projetService.FindAllAsync();
            return Ok(condidatDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProjetCreateDTO request)
        {
            var createProjetDTO = await _projetService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = createProjetDTO.Id }, createProjetDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProjetUpdateDTO updateRequest)
        {
            var updateCondidatDTO = await _projetService.UpdateAsync(id, updateRequest);

            if (updateCondidatDTO == null)
            {
                return NotFound();
            }

            return Ok(updateCondidatDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _projetService.DeleteAsync(id);
            return NoContent();
        }
    }
}
