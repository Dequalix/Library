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

        public List<Book> list()
        {
            return dataContext.Books.ToList();
        }
    }
}
