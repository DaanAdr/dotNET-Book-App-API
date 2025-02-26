using Book_App_API.Domain.DTOs.ReaderAgeDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReaderAgeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ReaderAgeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ReaderAge>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<ReaderAge> readerAges = await _dbContext.ReaderAges.ToListAsync();

                IEnumerable<ReaderAgeGetDTO> dtos = readerAges.Select(r => new ReaderAgeGetDTO
                {
                    Id = r.Id,
                    AgeRange = r.AgeRange
                });

                return Ok(dtos);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving authors. Please try again later.");
            }
        }
    }
}
