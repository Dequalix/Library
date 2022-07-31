using Library.API.Models;

namespace Library.API.Repositories
{
    public interface IUserRepository
    {
        List<User> List();
        List<User> FindUserByFirstName(string firstName);
        List<User> FindUserByLastName(string firstName);
        List<User> FindUserByAdres(string firstName);

        void SaveUser(User user);

    }
}
