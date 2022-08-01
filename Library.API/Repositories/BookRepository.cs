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

        public List<Book> Find(string input)
        {
            return dataContext.Books.Where((book) =>
            book.Title.Contains(input) ||
            book.Author.Contains(input) ||
            book.Language.Contains(input) ||
            book.Pages.ToString().Contains(input) ||
            book.Year.ToString().Contains(input)).ToList();
        }

        public void SaveBook(Book book)
        {
            dataContext.Add(book);
            dataContext.SaveChanges();
        }
    }
}
