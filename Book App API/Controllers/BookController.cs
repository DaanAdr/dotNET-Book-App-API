using Book_App_API.Domain.DTOs.BookDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly AppDbContext _dbContext;

        public BookController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                List<Book> books = await _dbContext.Books.ToListAsync();

                List<BookGetDTO> dtos = books.Select(b => new BookGetDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                    Pages = b.Pages,
                    PublishDate = b.PublishDate,
                    ReaderAge = b.ReaderAge.AgeRange,
                    Authors = b.BookAuthors.Select(a => $"{a.Author.Firstname} {a.Author.Surname}").ToList(),
                    Genres = b.BookGenres.Select(g => g.Genre.GenreName).ToList()
                }).ToList();

                return Ok(dtos);
            }
            catch (Exception)
            {
                // TODO: Log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving authors. Please try again later.");
            }
        }
    }
}
