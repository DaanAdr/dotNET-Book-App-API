using Microsoft.AspNetCore.Mvc;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : Controller
    {
        [HttpGet(Name = "GetGenre")]
        public string Get()
        {
            return "Hello world";
        }
    }
}
