using Library.BLL.Dtos.Book;
using Library.BLL.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _bookService.GetBooks();

            return Ok(result);
        }

        [HttpPost]
        public async Task Post(BookCreateDto bookCreateDto)
        {
            await _bookService.CreateBook(bookCreateDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id == null) return BadRequest();

            var result = await _bookService.GetBook(id);

            if (result == null) return NotFound();

            return Ok(result);

        }

        [HttpGet]
        [Route("Test")]
        public async Task<IActionResult> Test()
        {
            var result = await _bookService.Test();

            return Ok(result);
        }
    }
}
