using Library.API.Models;

namespace Library.API.Repositories
{
    public interface IUserRepository
    {
        List<User> List();
        List<User> Find(string search);
        void SaveUser(User user);
    }
}
