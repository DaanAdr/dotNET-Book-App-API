using Book_App_API.Domain.DTO;
using Book_App_API.Domain.Entity;
using Book_App_API.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : Controller
    {
        private readonly AuthorLogic _authorLogic;

        public AuthorController(AuthorLogic authorLogic)
        {
            _authorLogic = authorLogic;
        }

        [HttpGet(Name = "GetAuthors")]
        [ProducesResponseType(typeof(List<Author>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Author> authors = await _authorLogic.GetAuthors();
                return Ok(authors);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost(Name = "PostAuthors")]
        [ProducesResponseType(typeof(Author), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody]AuthorDTO author)
        {
            // Automatic validation of the AuthorDTO based on data annotations
            if (!ModelState.IsValid)
            {
                // Return a 400 Bad Request with the validation errors
                return BadRequest(ModelState);
            }

            try
            {
                Author response = await _authorLogic.PostAuthor(author);
                //return Ok(response);
                return Created(nameof(Post), response);
            }
            catch (ArgumentException ex) // Catch specific exceptions for validation
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
