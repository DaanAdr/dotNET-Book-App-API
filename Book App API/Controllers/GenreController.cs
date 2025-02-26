using Book_App_API.Domain.DTOs.GenreDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : Controller
    {
        private readonly AppDbContext _dbContext;

        public GenreController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Genre>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<Genre> genres = await _dbContext.Genres.ToListAsync();

                List<GenreGetDTO> dtos = genres.Select(g => new GenreGetDTO
                {
                    Id = g.Id,
                    GenreName = g.GenreName
                }).ToList();

                return Ok(dtos);
            }
            catch (Exception)
            {
                // TODO: Log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving authors. Please try again later.");
            }
        }
    }
}
