using Library.API.Models;

namespace Library.API.Repositories
{
    public interface IBookRepository 
    {
        // return, name, (params)
        List<Book> list(); 
    }
}
