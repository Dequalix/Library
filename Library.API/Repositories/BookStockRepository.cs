using Library.API.Models;

namespace Library.API.Repositories
{

    public class BookStockRepository : IBookStockRepository
    {
        private readonly DataContext dataContext;


        public void SetStockForBook(int bookId, int stock)
        {

        }

        public int GetStockForBook(int bookId)
        {
            return this.dataContext.BooksInStocks
                .Where((book) =>book.BookId.Equals(bookId))
                .First()
                .TotalStock
                .GetValueOrDefault(0);           
        }

    }
}
