/*using microservice.Auth.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace microservice.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly AppDbContext _context;
        public SearchController(AppDbContext context)
        {
            
        }
        [HttpGet]
        public IActionResult GetAll(string titleOffre, string city)
        {
            try
            {
                var filteredOffres = _context.offre;

                if (!string.IsNullOrEmpty(titleOffre))
                {
                    filteredOffres = filteredOffres.Where(o => o.Title.Contains(titleOffre, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (!string.IsNullOrEmpty(city))
                {
                    filteredOffres = filteredOffres.Where(o => o.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                // Filtrer les offres qui contiennent à la fois titleOffre et city
                if (!string.IsNullOrEmpty(titleOffre) && !string.IsNullOrEmpty(city))
                {
                    filteredOffres = filteredOffres.Where(o => o.Title.Contains(titleOffre, StringComparison.OrdinalIgnoreCase) && o.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                return Ok(filteredOffres);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
*/