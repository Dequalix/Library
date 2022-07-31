using Library.API.DTO;
using Library.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }


        List<BookDTO> Books = new List<BookDTO>();
        
        [HttpGet("list")]
        // scope, return, name, (params)
        public List<BookDTO> BookList()
        {
            // get books from db
            var books =  this._bookRepository.list();
            /// create return collectioin
            List<BookDTO> bookDtos = new List<BookDTO>();
            // foreach book from the database we will create a new BookDto and add the BookDto to the return collection
            books.ForEach(x => bookDtos.Add(new BookDTO { Title = x.Title, Published = x.Published }));
            // return the collection
            return bookDtos;


        }

        [HttpPost("addbook")]
        public void SaveBook(BookDTO book)
        {
            Books.Add(book);
        }

        [HttpGet("find")]
        public List<BookDTO> FindBook(string Title)
        {
            var results = new List<BookDTO>();
            foreach (BookDTO book in Books)
            {
                if (book.Title == Title)
                {
                    results.Add(book);
                }
            }
            return results;
        }
    }
}
