using Library.BLL.Dtos.Author;
using Library.BLL.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _authorService.GetAuthors();

            return Ok(result);
        }

        [HttpPost]
        public async Task Post(AuthorCreateDto authorCreateDto)
        {
            await _authorService.CreateAuthor(authorCreateDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id == null) return BadRequest();

            var result = await _authorService.GetAuthor(id);

            if (result == null) return NotFound();

            return Ok(result);

        }

        [HttpGet]
        [Route("Test")]
        public async Task<IActionResult> Test()
        {
            var result = await _authorService.Test();

            return Ok(result);
        }
    }
}
