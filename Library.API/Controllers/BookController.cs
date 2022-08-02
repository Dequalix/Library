using Library.API.DTO;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IServices _services;

        public BookController(IServices services)
        {
            _services = services;
        }

        [HttpGet("list")]
        // scope, return, name, (params)
        public List<BookDTO> BookList()
        {
            return _services.Booklist();
        }

        [HttpPost("addbook")]
        public void SaveBook(List<BookDTO> bookDto)
        {
            _services.SaveBook(bookDto);
        }

        [HttpGet("find")]
        public List<BookDTO> Find(string search)
        {
            return _services.FindBook(search);
        }
    }
}