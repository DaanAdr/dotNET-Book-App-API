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
        public async Task<List<Genre>> Get()
        {
            List<Genre> genres = await _genreLogic.GetGenres();
            return genres;
        }
    }
}
