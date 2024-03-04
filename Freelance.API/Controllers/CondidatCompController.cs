using Freelance.Application.Services.Condidate.CondidatCompService;
using Freelance.Application.Services.Condidate.OffreService;
using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Application.ViewModels.DTOs.OffreDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondidatCompController : ControllerBase
    {

        private readonly ICondidatCompService _condidatCompService;

        public CondidatCompController(ICondidatCompService condidatCompService)
        {
            _condidatCompService = condidatCompService;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var formationDTO = await _condidatCompService.FindByIdAsync(id);

            if (formationDTO == null)
            {
                return NotFound();
            }

            return Ok(formationDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var condidatDTO = await _condidatCompService.FindAllAsync();
            return Ok(condidatDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CondidatCompCreateDTO request)
        {
            var createDTO = await _condidatCompService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = createDTO.Id }, createDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CondidatCompUpdateDTO updateRequest)
        {
            var updateDTO = await _condidatCompService.UpdateAsync(id, updateRequest);

            if (updateDTO == null)
            {
                return NotFound();
            }

            return Ok(updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _condidatCompService.DeleteAsync(id);
            return NoContent();
        }
    }
}
