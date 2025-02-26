using Book_App_API.Business.Logic;
using Book_App_API.Domain.DTOs.AuthorDTOs;
using Book_App_API.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : Controller
    {
        private readonly AuthorLogic _logic;

        public AuthorController(AuthorLogic authorLogic)
        {
            _logic = authorLogic;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Author>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<AuthorGetDTO> authors = await _logic.GetAllAsync();
                return Ok(authors);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(Author), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostAsync([FromBody]AuthorPostDTO author)
        {
            // Automatic validation of the AuthorDTO based on data annotations
            if (!ModelState.IsValid)
            {
                // Return a 400 Bad Request with the validation errors
                return BadRequest(ModelState);
            }

            try
            {
                Author response = await _logic.PostAsync(author);

                return Created(nameof(PostAsync), response);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(Author), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PatchAsync(string id, [FromBody] AuthorPatchDTO author)
        {
            //Automatic validation of the AuthorDTO based on data annotations
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Author response = await _logic.PatchAsync(id, author);

                return Ok(response);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Author), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            try
            {
                await _logic.DeleteAsync(id);

                return Ok("Author deleted!");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
