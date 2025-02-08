using Book_App_API.Domain.DTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : Controller
    {
        private readonly IGenreLogic _logic;

        public GenreController(IGenreLogic genreLogic)
        {
            _logic = genreLogic;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Genre>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<GenreGetDTO> genres = await _logic.GetAllAsync();
                return Ok(genres);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
