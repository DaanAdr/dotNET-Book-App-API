using Book_App_API.Domain.Entity;
using Book_App_API.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReaderAgeController : Controller
    {
        private readonly IReaderAgeLogic _logic;

        public ReaderAgeController(IReaderAgeLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ReaderAge>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<ReaderAge> response = await _logic.GetAllAsync();
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
