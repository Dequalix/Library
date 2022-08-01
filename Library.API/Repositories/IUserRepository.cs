using Library.API.Models;

namespace Library.API.Repositories
{
    public interface IUserRepository
    {
        List<User> List();
        List<User> FindUserByName(string name);
        List<User> FindUserByAdres(string adres);
        void SaveUser(User user);
    }
}
