﻿using Book_App_API.Domain.DTO;
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
        [ProducesResponseType(typeof(Author), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody]AuthorDTO author)
        {
            if (author == null)
            {
                return BadRequest("Please provide author data.");
            }

            try
            {
                Author response = await _authorLogic.PostAuthor(author);
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
