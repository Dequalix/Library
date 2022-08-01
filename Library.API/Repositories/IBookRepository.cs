using Library.API.Models;

namespace Library.API.Repositories
{
    public interface IBookRepository 
    {
        // return, name, (params)
        List<Book> List(); 
        List<Book> Find(string search);
        void SaveBook(Book book);
    }
}
