using Library.API.Models;

namespace Library.API.Repositories
{
    public interface IBookStockRepository
    {
        void SetStockForBook(int bookId, int stock);
        int GetStockForBook(int bookId);
    }
}
