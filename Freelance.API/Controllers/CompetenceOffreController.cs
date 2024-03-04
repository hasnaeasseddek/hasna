using Freelance.Application.Services.Condidate.CompetenceOffreService;
using Freelance.Application.ViewModels.DTOs.CompetenceOffreDTO;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetenceOffreController : ControllerBase
    {
        private readonly ICompetenceOffreSevice _competenceOffreSevice;
        public CompetenceOffreController(ICompetenceOffreSevice condidateService)
        {
            _competenceOffreSevice = condidateService;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var competenceDTO = await _competenceOffreSevice.FindByIdAsync(id);

            if (competenceDTO == null)
            {
                return NotFound();
            }

            return Ok(competenceDTO);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var updateCompetenceDTO = await _competenceOffreSevice.FindAllAsync();
            return Ok(updateCompetenceDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CompetenceOffreCreateDTO createCompetenceOffreDTO)
        {
            var createCompetenceOffre = await _competenceOffreSevice.CreateAsync(createCompetenceOffreDTO);
            return CreatedAtAction(nameof(GetById), new { id = createCompetenceOffre.Id }, createCompetenceOffre);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CompetenceOffreUpdateDTO competenceOffreUpdateDTO)
        {
            var competenceOffreDTO = await _competenceOffreSevice.UpdateAsync(id, competenceOffreUpdateDTO);

            if (competenceOffreDTO == null)
            {
                return NotFound();
            }

            return Ok(competenceOffreDTO);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _competenceOffreSevice.DeleteAsync(id);
            return NoContent();
        }
    }
}
