using Freelance.Application.Services.Condidate.ExperienceService;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var formationDTO = await _experienceService.FindByIdAsync(id);

            if (formationDTO == null)
            {
                return NotFound();
            }

            return Ok(formationDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var condidatDTO = await _experienceService.FindAllAsync();
            return Ok(condidatDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ExperienceCreateDTO request)
        {
            var createExperienceDTO = await _experienceService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = createExperienceDTO.Id }, createExperienceDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ExperienceUpdateDTO updateRequest)
        {
            var updateExperienceDTO = await _experienceService.UpdateAsync(id, updateRequest);

            if (updateExperienceDTO == null)
            {
                return NotFound();
            }

            return Ok(updateExperienceDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _experienceService.DeleteAsync(id);
            return NoContent();
        }
    }
}
