using Book_App_API.Domain.DTOs.AuthorDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AuthorController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Author>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<Author> authors = await _dbContext.Author.AsNoTracking().ToListAsync();

                List<AuthorGetAndDeleteDTO> dtos = authors.Select(a => new AuthorGetAndDeleteDTO
                {
                    Id = a.Id,
                    Firstname = a.Firstname,
                    Surname = a.Surname
                }).ToList();

                return Ok(dtos);
            }
            catch (Exception ex)
            {
                // TODO: Log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving authors. Please try again later.");
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(Author), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostAsync([FromBody]AuthorPostDTO author)
        {
            // Automatic validation of the AuthorDTO based on data annotations
            //if (!ModelState.IsValid)
            //{
            //    // Return a 400 Bad Request with the validation errors
            //    return BadRequest(ModelState);
            //}

            try
            {
                Author authorEntity = new Author
                {
                    Firstname = author.Firstname,
                    Surname = author.Surname
                };

                _dbContext.Author.Add(authorEntity);
                await _dbContext.SaveChangesAsync();

                //return Created(nameof(PostAsync), response);
                return CreatedAtAction(nameof(PostAsync), new { id = authorEntity.Id }, authorEntity);
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
        public async Task<IActionResult> PatchAsync(int id, [FromBody] AuthorPatchDTO author)
        {
            //Automatic validation of the AuthorDTO based on data annotations
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            try
            {
                Author? authorToPatch = await _dbContext.Author.FindAsync(id);

                // Check if the author was found
                if (author == null)
                {
                    return NotFound($"Author with ID {id} not found.");
                }

                // Update only the fields that are provided in the request
                if (!string.IsNullOrWhiteSpace(author.Firstname)) authorToPatch!.Firstname = author.Firstname;
                if (!string.IsNullOrWhiteSpace(author.Surname)) authorToPatch!.Surname = author.Surname;

                _dbContext.Update(authorToPatch!);
                await _dbContext.SaveChangesAsync();

                return Ok(authorToPatch);
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
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                Author? author = await _dbContext.Author.FindAsync(id);

                // Check if the author was found
                if (author == null)
                {
                    return NotFound($"Author with ID {id} not found.");
                }

                // Remove the author
                _dbContext.Author.Remove(author);
                await _dbContext.SaveChangesAsync(); // Ensure changes are saved

                return Ok("Author deleted!");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
