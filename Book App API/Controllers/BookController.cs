using Book_App_API.Business.Logic;
using Book_App_API.Domain.DTOs.BookDTOs;
using Book_App_API.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly BookLogic _logic;

        public BookController(BookLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<BookGetDTO> genres = await _logic.GetAllAsync();
                return Ok(genres);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
