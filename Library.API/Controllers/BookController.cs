using Library.API.DTO;
using Library.API.Models;
using Library.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }


        
        [HttpGet("list")]
        // scope, return, name, (params)
        public List<BookDTO> BookList()
        {
            return this._bookRepository.List().Select(Mapper.ToBookDto).ToList();
        }

        [HttpPost("addbook")]
        public void SaveBook(List<BookDTO> bookDto)
        {
            bookDto.ForEach(book => this._bookRepository.SaveBook(Mapper.ToBook(book)));
        }

        [HttpGet("find")]
        public List<BookDTO> FindBook(string Title)
        {
            //  get books with title
            return this._bookRepository.Find(Title).Select(Mapper.ToBookDto).ToList();
        }
    }
}