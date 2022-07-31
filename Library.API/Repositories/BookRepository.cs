using Library.API.Models;

namespace Library.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext dataContext;

        public BookRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Book> List()
        {
            return dataContext.Books.ToList();
        }

        public List<Book> Find(string title)
        {
            return dataContext.Books.Where((book) => book.Title.Contains(title)).ToList();
        }

        public void SaveBook(Book book)
        {
            dataContext.Add(book);
            dataContext.SaveChanges();
        }
    }
}
