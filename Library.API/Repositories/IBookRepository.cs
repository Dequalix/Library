using Library.API.Models;

namespace Library.API.Repositories
{
    public interface IBookRepository 
    {
        // return, name, (params)
        List<Book> List(); 
        List<Book> Find(string Book);

        void SaveBook(Book book);
    }
}
