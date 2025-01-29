using Book_App_API.Domain.Entity;
using Book_App_API.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : Controller
    {
        private readonly GenreLogic _genreLogic;

        public GenreController(GenreLogic genreLogic)
        {
            _genreLogic = genreLogic;
        }

        [HttpGet(Name = "GetGenre")]
        [ProducesResponseType(typeof(List<Genre>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Genre> genres = await _genreLogic.GetGenres();
                return Ok(genres);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
