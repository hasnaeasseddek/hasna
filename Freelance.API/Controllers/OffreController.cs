using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.Services.Condidate.OffreService;
using Microsoft.AspNetCore.Mvc;
using Freelance.Application.ViewModels.DTOs.OffreDTO;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffreController : ControllerBase
    {
        private readonly IOffreService _offreService;

        public OffreController(IOffreService offreService)
        {
            _offreService = offreService;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var formationDTO = await _offreService.FindByIdAsync(id);

            if (formationDTO == null)
            {
                return NotFound();
            }

            return Ok(formationDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var condidatDTO = await _offreService.FindAllAsync();
            return Ok(condidatDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OffreCreateDTO request)
        {
            var createDTO = await _offreService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = createDTO.Id }, createDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] OffreUpdateDTO updateRequest)
        {
            var updateDTO = await _offreService.UpdateAsync(id, updateRequest);

            if (updateDTO == null)
            {
                return NotFound();
            }

            return Ok(updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _offreService.DeleteAsync(id);
            return NoContent();
        }
    }
}
